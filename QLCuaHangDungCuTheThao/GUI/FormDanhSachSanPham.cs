using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormDanhSachSanPham : Form
    {
        DanhSachSanPhamBLL danhSachSanPhamBLL;
        public FormDanhSachSanPham()
        {
            InitializeComponent();
            tbTimKiem.Focus();
            GrVDanhSach.AutoGenerateColumns = false;
            
        }
        public Panel PanelPageDanhSachSanPham
        {
            get
            {
                danhSachSanPhamBLL = new DanhSachSanPhamBLL();
                GrVDanhSach.DataSource = danhSachSanPhamBLL.Listsanpham;
                GrVDanhSach.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                taoDataChoComboBox();
                return panelPageDanhSachSanPham;
            }
        }
        /*-----------------------------------------------SỰ KIỆN------------------------------------------------*/
        // ngăn chặn tự động chọn dòng đầu tiên trong danh sách
        private void yourDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            GrVDanhSach.ClearSelection();
        }

        private void btThemSP_Click(object sender, EventArgs e)
        {
            if (!TaiKhoanBLL.TaiKhoan.Role)
            {
                MessageBox.Show("Bạn không có quyền thêm sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            FormThemSP formThemSP = new FormThemSP();
            formThemSP.ShowDialog();
        }

        private void btXoaSP_Click(object sender, EventArgs e)
        {
            if (!TaiKhoanBLL.TaiKhoan.Role)
            {
                MessageBox.Show("Bạn không có quyền xóa sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //lấy danh sách mã sản phẩm được chọn
            List<string> selectedMa = new List<string>();
            foreach (DataGridViewRow row in GrVDanhSach.Rows)
            {
                DataGridViewCheckBoxCell checkbox = (DataGridViewCheckBoxCell)row.Cells["chon"];
                if (checkbox.Value != null && (bool)checkbox.Value)
                {
                    selectedMa.Add(row.Cells["Ma"].Value.ToString());
                }
            }

            if (selectedMa.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa " + selectedMa.Count.ToString() + " sản phẩm đã chọn\ncùng với tất cả những đơn hàng liên quan?", "Nhắc nhở", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    int deleted = 0;
                    int notDeleted = 0;
                    //xóa sản phẩm
                    foreach (string maSP in selectedMa)
                    {
                        XemChiTietSPBLL xemChiTietSPBLL = new XemChiTietSPBLL(maSP);
                        if (xemChiTietSPBLL.layChiTietHoaDon(maSP))
                        {
                            if (!xemChiTietSPBLL.xoaSanPhamDaBan())
                            {
                                notDeleted++;
                                continue;
                            }
                            deleted++;
                        }
                        else
                        {
                            if (!xemChiTietSPBLL.xoaSanPhamChuaBan())
                            {
                                notDeleted++;
                                continue;
                            }
                            deleted++;
                        }
                    }

                    MessageBox.Show("Xóa thành công " + deleted.ToString() + " sản phẩm");
                    if (notDeleted > 0)
                    {
                        MessageBox.Show("Không thể xóa " + notDeleted.ToString() + " sản phẩm.\n Đã xảy ra lỗi trong quá trình xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    //refresh lại danh sách sản phẩm
                    danhSachSanPhamBLL = new DanhSachSanPhamBLL();
                    GrVDanhSach.DataSource = danhSachSanPhamBLL.Listsanpham;
                    GrVDanhSach.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
        }

        private void GrVDanhSach_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormChiTietSP formChiTietSP = new FormChiTietSP(danhSachSanPhamBLL.Listsanpham.Rows[e.RowIndex]["MaSP"].ToString());
            formChiTietSP.ShowDialog();
            //refresh lại danh sách sản phẩm phòng trường hợp xóa sản phẩm
            if (XemChiTietSPBLL.xoa)
            {
                danhSachSanPhamBLL = new DanhSachSanPhamBLL();
                GrVDanhSach.DataSource = danhSachSanPhamBLL.Listsanpham;
                GrVDanhSach.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                XemChiTietSPBLL.xoa = false;
            }

        }

        private void chkBChonTatCa_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in GrVDanhSach.Rows)
            {
                DataGridViewCheckBoxCell checkbox = (DataGridViewCheckBoxCell)row.Cells["chon"];
                checkbox.Value = chkBChonTatCa.Checked;
            }
        }

        /*----------------------------------------------- HẾT SỰ KIỆN------------------------------------------------*/
        private void taoDataChoComboBox()
        {
            cbDanhMuc.DataSource = danhSachSanPhamBLL.getDanhMuc();
            cbDanhMuc.SelectedItem = "Tất cả";
            cbTrangThai.DataSource = danhSachSanPhamBLL.getTrangThai();
            cbTrangThai.SelectedItem = "Tất cả";
            cbSapXep.DataSource = danhSachSanPhamBLL.getSapXep();
            cbSapXep.SelectedItem = "Mặc định";
        }


    }
}
