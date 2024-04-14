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
using DTO;

namespace GUI
{
    public partial class FormTaoDonHang : Form
    {
        DonHangBLL DonHangBLL = new DonHangBLL();

        public FormTaoDonHang()
        {
            InitializeComponent();
            btTaoDonMoi_pageTaoDonHang_Click(null, null);
            //test
            //lbTienThua_pageTaoDonHang.Text = "100,000,000 VNĐ";
            //lbMaNV_pageTaoDonHang.Text = "NV001";
        }
        public Panel PanelPageTaoDonHang
        {          
            get
            {
                return panelPageTaoDonHang;
            }
        }

        //để dễ kiểm soát việc cập nhật số thứ tự của các dòng trong các danh sách
        public interface ISttUserControl
        {
            string STT { get; set; }
        }

        /*--------------------------------------------------SỰ KIỆN---------------------------------------------------*/

        private void tbSDT_pageTaoDonHang__TextChanged(object sender, EventArgs e)
        {
            if (tbSDT_pageTaoDonHang.Texts.Length >= 10)
            {
                DonHangBLL.NhapSDT(tbSDT_pageTaoDonHang.Texts);
            }
        }

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
                DataTable dt = DonHangBLL.LoadResults_For_SearchSPTextbox(text);
                GrVThemSPResult_pageTaoDonHang.DataSource = dt;

                

                if (GrVThemSPResult_pageTaoDonHang.Rows.Count > 0)
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
            //Xóa tất cả các UserControl trong flpRows_DanhSach1
            flpRows_DanhSach1.Controls.Clear();

            lbChietKhau_pageTaoDonHang.Text = "";
            lbTongTien_pageTaoDonHang.Text = "";
            lbSoTienKhachPhaiTra_pageTaoDonHang.Text = "";
            lbMaDH.Text = "";
            lbMaNV_pageTaoDonHang.Text = "";
            lbTienThua_pageTaoDonHang.Text = "";
            tbSDT_pageTaoDonHang.Texts = "";
            tbSoTienKhachDua_pageTaoDonHang.Texts = "";
            tbGhiChu_pageTaoDonHang.Texts = "";
            radioTienMat_pageTaoDonHang.Checked = true;

            // Tạo listChiTietHoaDon mới
            DonHangBLL = new DonHangBLL();

            lbMaDH.Text = DonHangBLL.HoaDon.MaHD;
        }
        private void GrVThemSPResult_pageTaoDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = GrVThemSPResult_pageTaoDonHang.Rows[e.RowIndex];
            string maSP = row.Cells["MaSP"].Value.ToString();
            tbThemSP_pageTaoDonHang.Texts = "";
            //Hiển thị dữ liệu lên flpRows_DanhSach1
            UCRowTaoDH uc = new UCRowTaoDH();
            if (DonHangBLL.ThemChiTietHoaDon(maSP))
            {
                uc.MaSP = maSP;
                uc.TenSP = GeneralBLL.GetSanPham(maSP).TenSP;
                uc.DonGia = DonHangBLL.GetChiTietHoaDon(maSP).DonGia.ToString("N0");
                uc.SoLuong = DonHangBLL.GetChiTietHoaDon(maSP).SoLuong.ToString();
                uc.ThanhTien = DonHangBLL.GetChiTietHoaDon(maSP).ThanhTien.ToString("N0");
                uc.Width = flpRows_DanhSach1.Width;
                uc.BtXoaClicked += Uc_BtXoaClicked; //Gán sự kiện cho sự kiện tùy chỉnh của UCRowTaoDH
                uc.tbSoLuongChanged += Uc_TbSoLuongChanged; //Gán sự kiện cho sự kiện tùy chỉnh của UCRowTaoDH
                flpRows_DanhSach1.Controls.Add(uc);
                UpdateSTT(flpRows_DanhSach1);
                GrVThemSPResult_pageTaoDonHang.Height = 0;
            } else
            {
                //Cập nhất lại soluong và thanhtien của UCRowTaoDH
                foreach (Control control in flpRows_DanhSach1.Controls)
                {
                    if (control is UCRowTaoDH ucRowTaoDH && ucRowTaoDH.MaSP == maSP)
                    {
                        ucRowTaoDH.SoLuong = DonHangBLL.GetChiTietHoaDon(maSP).SoLuong.ToString();
                        ucRowTaoDH.ThanhTien = DonHangBLL.GetChiTietHoaDon(maSP).ThanhTien.ToString("N0");
                        break;
                    }
                }
            }
            CapNhatViTriLbSoTienKhachPhaiTra(DonHangBLL.HoaDon.TienKhachPhaiTra.ToString("N0") + " VNĐ");
            lbTongTien_pageTaoDonHang.Text = DonHangBLL.HoaDon.TongTienHang.ToString("N0") + " VNĐ";
            lbChietKhau_pageTaoDonHang.Text = DonHangBLL.HoaDon.ChietKhau.ToString("N0") + " VNĐ";
        }

        private void btThanhToan_pageTaoDonHang_Click(object sender, EventArgs e)
        {
            DonHangBLL.HoaDon.MaNV = lbMaNV_pageTaoDonHang.Text;
            DonHangBLL.HoaDon.GhiChu = tbGhiChu_pageTaoDonHang.Texts;
            DonHangBLL.HoaDon.PhuongThucThanhToan = radioTienMat_pageTaoDonHang.Checked ? "Tiền mặt" : "Chuyển khoản"; 
            DonHangBLL.TaoDonHang();
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
            DonHangBLL.XoaChiTietHoaDon(ucRowTaoDH.MaSP);
            flpRows_DanhSach1.Controls.Remove(ucRowTaoDH);
            UpdateSTT(flpRows_DanhSach1);
            //cập nhật các label
            CapNhatViTriLbSoTienKhachPhaiTra(DonHangBLL.HoaDon.TienKhachPhaiTra.ToString("N0") + " VNĐ");
            lbTongTien_pageTaoDonHang.Text = DonHangBLL.HoaDon.TongTienHang.ToString("N0") + " VNĐ";
            lbChietKhau_pageTaoDonHang.Text = DonHangBLL.HoaDon.ChietKhau.ToString("N0") + " VNĐ";
        }

        private void Uc_TbSoLuongChanged(object sender, EventArgs e)
        {
            UCRowTaoDH ucRowTaoDH = sender as UCRowTaoDH;
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
                DonHangBLL.UpdateSoLuongChiTietHoaDon(ucRowTaoDH.MaSP, ucRowTaoDH.SoLuong);
                ucRowTaoDH.ThanhTien = DonHangBLL.GetChiTietHoaDon(ucRowTaoDH.MaSP).ThanhTien.ToString();
                CapNhatViTriLbSoTienKhachPhaiTra(DonHangBLL.HoaDon.TienKhachPhaiTra.ToString("N0") + " VNĐ");
                lbTongTien_pageTaoDonHang.Text = DonHangBLL.HoaDon.TongTienHang.ToString("N0") + " VNĐ";
                lbChietKhau_pageTaoDonHang.Text = DonHangBLL.HoaDon.ChietKhau.ToString("N0") + " VNĐ";
            }
        }
        /*-----------------------------------------------HẾT CÁC HÀM XỬ LÝ------------------------------------------------*/
    }
}
