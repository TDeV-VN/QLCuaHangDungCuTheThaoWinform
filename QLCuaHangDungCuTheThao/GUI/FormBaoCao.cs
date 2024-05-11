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
    public partial class FormBaoCao : Form
    {
        private TaiKhoan taiKhoanSelected = new TaiKhoan();
        public FormBaoCao()
        {
            InitializeComponent();
            cbQuyen.Items.AddRange(new string[] { "Quản lý", "Nhân viên" });
            cbQuyen_tao.Items.AddRange(new string[] { "Quản lý", "Nhân viên" });
            cbTrangThai.Items.AddRange(new string[] { "Đang hoạt động", "Khóa" });
            cbQuyen_tao.SelectedItem = "Nhân viên";
            GrVDanhSachTK.AutoGenerateColumns = false;
        }
        public Panel PanelPageBaoCao
        {
            get
            {
                TaiKhoanBLL.layDanhSach();
                GrVDanhSachTK.DataSource = TaiKhoanBLL.DanhSach;
                return panelPageBaoCao;
            }
        }

        // ngăn chặn tự động chọn dòng đầu tiên trong danh sách
        private void yourDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            GrVDanhSachTK.ClearSelection();
        }

        private void GrVDanhSachTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btLuu.Enabled = true;
            DataGridViewRow row = this.GrVDanhSachTK.Rows[e.RowIndex];
            string manv = row.Cells["MaNV"].Value.ToString();
            taiKhoanSelected = TaiKhoanBLL.DanhSach.Find(x => x.MaNV == manv);
            tbMa.Texts = taiKhoanSelected.MaNV;
            tbEmail.Texts = taiKhoanSelected.Email;
            if (taiKhoanSelected.Role)
            {
                cbQuyen.SelectedIndex = 0;
            }
            else
            {
                cbQuyen.SelectedIndex = 1;
            }
            if (taiKhoanSelected.TrangThai)
            {
                cbTrangThai.SelectedIndex = 0;
            }
            else
            {
                cbTrangThai.SelectedIndex = 1;
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            //Nếu có sự thay đổi
            if (tbEmail.Texts != taiKhoanSelected.Email || cbQuyen.SelectedIndex != (taiKhoanSelected.Role ? 0 : 1) || cbTrangThai.SelectedIndex != (taiKhoanSelected.TrangThai ? 0 : 1))
            {
                taiKhoanSelected.Email = tbEmail.Texts;
                taiKhoanSelected.Role = cbQuyen.SelectedIndex == 0 ? true : false;
                taiKhoanSelected.TrangThai = cbTrangThai.SelectedIndex == 0 ? true : false;
                if (TaiKhoanBLL.capNhat(taiKhoanSelected))
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GrVDanhSachTK.DataSource = TaiKhoanBLL.DanhSach;
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
