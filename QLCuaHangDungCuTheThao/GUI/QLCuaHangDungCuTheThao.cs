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
    public partial class QLCuaHangDungCuTheThao : Form
    {
        public QLCuaHangDungCuTheThao()
        {
            InitializeComponent();
        }

        /* SỰ KIỆN CÁC BUTTON TABPAGE ĐƯỢC CLICK*/
        private void btSportShop_Click(object sender, EventArgs e)
        {
            btTabPageTongQuan_Click(sender, e);
        }
        private void btTabPageTongQuan_Click(object sender, EventArgs e)
        {
            lbPageHeader.Text = "Tổng quan";

        }

        private void btTabPageTaoDon_Click(object sender, EventArgs e)
        {
            lbPageHeader.Text = "Tạo đơn hàng";

        }

        private void btTabPageDanhSachDH_Click(object sender, EventArgs e)
        {
            lbPageHeader.Text = "Danh sách đơn hàng";

        }

        private void btTabPageDanhSachSP_Click(object sender, EventArgs e)
        {
            lbPageHeader.Text = "Danh sách sản phẩm";
        }

        private void btTabPageDanhMucSP_Click(object sender, EventArgs e)
        {
            lbPageHeader.Text = "Danh mục sản phẩm";
        }

        private void btTabPageKhachHang_Click(object sender, EventArgs e)
        {
            lbPageHeader.Text = "Khách hàng";
        }

        private void btTabPagePhieuThu_Click(object sender, EventArgs e)
        {
            lbPageHeader.Text = "Phiếu thu";
        }

        private void btTabPagePhieuChi_Click(object sender, EventArgs e)
        {
            lbPageHeader.Text = "Phiếu chi";
        }

        private void btTabPageSoQuy_Click(object sender, EventArgs e)
        {
            lbPageHeader.Text = "Sổ quỹ";
        }

        private void btTabPageBaoCao_Click(object sender, EventArgs e)
        {
            lbPageHeader.Text = "Báo cáo";
        }
        /* HẾT SỰ KIỆN CÁC BUTTON TABPAGE ĐƯỢC CLICK*/

        /* SỰ KIỆN CLICK VÀO GROUP TÀI KHOẢN TRÊN HEADER*/
        private void btIconUser_Click(object sender, EventArgs e)
        {

        }

        private void btIconUser_text_Click(object sender, EventArgs e)
        {

        }
        /* HẾT SỰ KIỆN CLICK VÀO GROUP TÀI KHOẢN TRÊN HEADER*/

    }
}
