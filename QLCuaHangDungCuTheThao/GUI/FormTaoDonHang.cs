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
    public partial class FormTaoDonHang : Form
    {
        public FormTaoDonHang()
        {
            InitializeComponent();
            TaoDuLieu();
        }
        public Panel PanelPageTaoDonHang
        {
            get
            {
                return panelPageTaoDonHang;
            }
        }

        /*dữ liệu test*/
        DataTable dt = new DataTable(); //Hiển thị sản phẩm đã chọn lên danh sách đơn hàng
        DataTable dt1 = new DataTable(); //Hiển thị danh sách sản phẩm lên tìm kiếm sản phẩm
        public void TaoDuLieu()
        {
            dt.Columns.Add("MaSP", typeof(string));
            dt.Columns.Add("TenSP", typeof(string));
            dt.Columns.Add("DonGia", typeof(string));
            dt.Columns.Add("ThanhTien", typeof(string));
            dt.Rows.Add("SP001", "Áo thể thao", "10,000,000", "10,000,000");

            dt1.Columns.Add("MaSP", typeof(string));
            dt1.Columns.Add("TenSP", typeof(string));
            dt1.Rows.Add("SP001", "Áo thể thao");
            dt1.Rows.Add("SP002", "Quần thể thao");
            dt1.Rows.Add("SP003", "Giày thể thao");
            dt1.Rows.Add("SP004", "Áo khoác thể thao");
        }

        //để dễ kiểm soát việc cập nhật số thứ tự của các dòng trong các danh sách
        public interface ISttUserControl

        {
            string STT { get; set; }
        }

        /*--------------------------------------------------SỰ KIỆN---------------------------------------------------*/


        //đặt chiều rộng cho các control trong flpRows_DanhSach1
        private void flpRows_DanhSach1_Resize(object sender, EventArgs e)
        {
            foreach (Control control in flpRows_DanhSach1.Controls)
            {
                if (control is UCRowTaoDH)
                {
                    control.Width = flpRows_DanhSach1.Width;
                }
            }
        }

        //click ra ngoài textbox thì ẩn con trỏ
        private void textBox_Leave(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        /*tìm kiếm để thêm sp vào đơn hàng*/
        private void tbSearchSP_pageTaoDH_TextChanged(object sender, EventArgs e)
        {
            string text = tbThemSP_pageTaoDonHang.Texts;
            if (text.Length >= 4)
            {

                //DataGridView dt1 = LoadResults_For_SearchSPTextbox(text);
                GrVThemSPResult_pageTaoDonHang.DataSource = dt1;
                if (dt1.Rows.Count > 0)
                {
                    GrVThemSPResult_pageTaoDonHang.Height = GrVThemSPResult_pageTaoDonHang.RowCount * 30;

                }
                else
                {
                    GrVThemSPResult_pageTaoDonHang.Height = 0;
                }
            }
            else
            {
                GrVThemSPResult_pageTaoDonHang.Height = 0;
            }
        }

        private void btTaoDonMoi_pageTaoDonHang_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon(TaoDonHang.AutoGenerateMaHD());
            lbMaDH.Text = hd.MaHD;
        }
        private void GrVThemSPResult_pageTaoDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = GrVThemSPResult_pageTaoDonHang.Rows[e.RowIndex];
            string maSP = row.Cells["MaSP"].Value.ToString();
            tbThemSP_pageTaoDonHang.Texts = "";
            //Hiển thị dữ liệu lên flpRows_DanhSach1

            /* Lấy nhưng Chưa test*/
            /*SanPham sp = TaoDonHangBLL.GetSanPham_With_MaSP(maSP);
            UCRowTaoDH uc = new UCRowTaoDH();
            uc.MaSP = sp.MaSP;
            uc.TenSP = sp.TenSP;
            uc.DonGia = sp.GiaBan;
            uc.SoLuong = "1"; //Mặc định số lượng là 1
            uc.ThanhTien = sp.GiaBan;*/
            /*lấy nhưng chưa test*/

            /*test*/
            UCRowTaoDH uc = new UCRowTaoDH();
            uc.MaSP = dt.Rows[0]["MaSP"].ToString();
            uc.TenSP = dt.Rows[0]["TenSP"].ToString();
            uc.DonGia = dt.Rows[0]["DonGia"].ToString();
            uc.SoLuong = "1";
            uc.ThanhTien = dt.Rows[0]["ThanhTien"].ToString();
            /*test*/
            uc.Width = flpRows_DanhSach1.Width;
            uc.BtXoaClicked += Uc_BtXoaClicked; //Gán sự kiện cho sự kiện tùy chỉnh của UCRowTaoDH
            uc.tbSoLuongChanged += Uc_TbSoLuongChanged; //Gán sự kiện cho sự kiện tùy chỉnh của UCRowTaoDH
            flpRows_DanhSach1.Controls.Add(uc);
            UpdateSTT(flpRows_DanhSach1);

            GrVThemSPResult_pageTaoDonHang.Height = 0;
        }
        /*------------------------------------------------HẾT CÁC SỰ KIỆN-------------------------------------------------*/

        /*------------------------------------------------CÁC HÀM XỬ LÝ---------------------------------------------------*/
 
        //đặt lại văn bản và vị trí cho label số tiền khách phải trả
        private void CapNhatViTriLbSoTienKhachPhaiTra(string vanBanMoi)
        {
            // Cập nhật văn bản
            lbSoTienKhachPhaiTra_pageTaoDonHang.Text = vanBanMoi;

            // Đặt vị trí trung tâm cố định
            int fixedCenterPosition = 127;
            int labelWidth = lbSoTienKhachPhaiTra_pageTaoDonHang.Width;
            int newLeftPosition = fixedCenterPosition - (labelWidth / 2);

            // Vẽ lại vị trí
            lbSoTienKhachPhaiTra_pageTaoDonHang.Left = newLeftPosition;
        }

        //cập nhật STT cho tất cả các UserControl triển khai ISttUserControl trong một FlowLayoutPanel:
        private void UpdateSTT(FlowLayoutPanel flowLayoutPanel)
        {
            int stt = 1;
            foreach (Control control in flowLayoutPanel.Controls)
            {
                if (control is ISttUserControl)
                {
                    ISttUserControl sttUserControl = control as ISttUserControl;
                    sttUserControl.STT = stt.ToString();
                    stt++;
                }
            }
        }

        //hàm xử lý sự kiện btXoa_Click của UCRowTaoDH
        private void Uc_BtXoaClicked(object sender, EventArgs e)

        {
            UCRowTaoDH ucRowTaoDH = sender as UCRowTaoDH;
            flpRows_DanhSach1.Controls.Remove(ucRowTaoDH);
            UpdateSTT(flpRows_DanhSach1);
        }

        private void Uc_TbSoLuongChanged(object sender, EventArgs e)
        {
            UCRowTaoDH ucRowTaoDH = sender as UCRowTaoDH;
            //Cập nhật thành tiền
            if (ucRowTaoDH.SoLuong == "")
            {
                ucRowTaoDH.SoLuong = "0";
            }
            else if (ucRowTaoDH.SoLuong == "0")
            {
                Uc_BtXoaClicked(ucRowTaoDH, e);
            }
            else
            {
                /*string thanhTien = TaoDonHangBLL.UpdateThanhTien(ucRowTaoDH.MaSP, ucRowTaoDH.SoLuong);
                ucRowTaoDH.ThanhTien = thanhTien;*/

                //test
                MessageBox.Show("Thành tiền đã được cập nhật");
            }
        }


        /*-----------------------------------------------HẾT CÁC HÀM XỬ LÝ------------------------------------------------*/
    }
}
