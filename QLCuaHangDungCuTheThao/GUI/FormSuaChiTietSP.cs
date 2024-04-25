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
using static System.Net.Mime.MediaTypeNames;

namespace GUI
{
    public partial class FormSuaChiTietSP : Form
    {
        public FormSuaChiTietSP()
        {
            InitializeComponent();
            tbMoTa.ScrollBars = ScrollBars.Vertical;
            GrVTrangThai.ScrollBars = ScrollBars.None;

        }
        public Panel PanelSuaChiTietSP
        {
            get 
            {
                GrVTrangThai.Visible = false;
                GrVDanhMuc.Visible = false;
                tbTrangThai.Texts = "Đang mở bán";
                return panelSuaChiTietSP; 
            }
        }

        private void tbTrangThai_Click(object sender, EventArgs e)
        {
            DataTable dtTrangThai = new DataTable();
            dtTrangThai.Columns.Add("trangThai");
            dtTrangThai.Rows.Add("Đang mở bán");
            dtTrangThai.Rows.Add("Dừng bán");
            GrVTrangThai.DataSource = dtTrangThai;
            GrVTrangThai.Visible = true;
        }

        private void tbTrangThai__TextChanged(object sender, EventArgs e)
        {
            //Không cho nhập
            tbTrangThai.Texts = "Đang mở bán";
        }

        private void tbDanhMuc_Click(object sender, EventArgs e)
        {
            //test
            DataTable dtDanhMuc = new DataTable();
            dtDanhMuc.Columns.Add("danhMuc");
            dtDanhMuc.Rows.Add("Điện thoại");
            dtDanhMuc.Rows.Add("Laptop");
            dtDanhMuc.Rows.Add("Máy ảnh");
            dtDanhMuc.Rows.Add("Máy tính bảng");
            dtDanhMuc.Rows.Add("Phụ kiện");
            dtDanhMuc.Rows.Add("Sim thẻ");
            dtDanhMuc.Rows.Add("Thiết bị âm thanh");
            dtDanhMuc.Rows.Add("Thiết bị số");
            dtDanhMuc.Rows.Add("Thiết bị văn phòng");
            dtDanhMuc.Rows.Add("Thiết bị điện tử");
            dtDanhMuc.Rows.Add("Thiết bị điện lạnh");
            dtDanhMuc.Rows.Add("Thiết bị gia dụng");
            GrVDanhMuc.DataSource = dtDanhMuc;
            GrVDanhMuc.Visible = true;
        }

        private void tbDanhMuc__TextChanged(object sender, EventArgs e)
        {
            //Không cho nhập
            tbDanhMuc.Texts = "";
        }
    }
}
