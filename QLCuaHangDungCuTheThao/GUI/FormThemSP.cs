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
    public partial class FormThemSP : Form
    {
        bool isClickOnCate = false;
        bool isClickOnState = false;
        public string urlAvatar;
        public List<string> urlNonAvatar = new List<string>();
        DataTable category = new DataTable();
        private SanPham product = new SanPham();
        private SuaChiTietSPBLL suaChiTietSPBLL = new  SuaChiTietSPBLL("");
        public FormThemSP()
        {
            InitializeComponent();
            GrVTrangThai.Visible = false;
            GrVDanhMuc.Visible = false;
            tbMoTa.ScrollBars = ScrollBars.Vertical;
            GrVTrangThai.ScrollBars = ScrollBars.None;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbTrangThai__TextChanged(object sender, EventArgs e)
        {
            if (isClickOnState)
            {
                isClickOnCate = false;
                return;
            }
            else
            {
                if (product.MoBan)
                {
                    tbTrangThai.Texts = "Đang mở bán";
                }
                else
                {
                    tbTrangThai.Texts = "Dừng bán";
                }
            }
        }

        private void tbDanhMuc_Click(object sender, EventArgs e)
        {
            // Tắt option của trạng thái
            GrVTrangThai.Visible = false;
            DataTable cateName = new DataTable();
            cateName.Columns.Add("danhMuc");
            foreach (DataRow cate in suaChiTietSPBLL.ListDanhMuc.Rows)
            {
                cateName.Rows.Add(cate["TenDM"].ToString());
            }
            GrVDanhMuc.DataSource = cateName;
            GrVDanhMuc.Visible = true;
        }

        private void tbDanhMuc__TextChanged(object sender, EventArgs e)
        {
            //Không cho nhập
            if (isClickOnCate)
            {
                isClickOnCate = false;
                return;
            }
            else
            {
                tbDanhMuc.Texts = suaChiTietSPBLL.getTenDanhMucByMaDM(product.MaDM);
            }
        }

        private void tbTrangThai_Click(object sender, EventArgs e)
        {
            // Tắt option của danh mục
            GrVDanhMuc.Visible = false;
            DataTable dtTrangThai = new DataTable();
            dtTrangThai.Columns.Add("trangThai");
            dtTrangThai.Rows.Add("Đang mở bán");
            dtTrangThai.Rows.Add("Dừng bán");
            GrVTrangThai.DataSource = dtTrangThai;
            GrVTrangThai.Visible = true;
        }

        public void updateProduct()
        {
            product.TenSP = tbTenSP.Texts;
            foreach (DataRow dr in category.Rows)
            {
                if (dr["TenDM"].ToString() == tbDanhMuc.Texts)
                {
                    product.MaDM = dr["MaDM"].ToString();
                    break;
                }
            }
            product.GiaBan = Convert.ToInt32(tbGiaBan.Texts);
            product.GiaNhap = Convert.ToInt32(tbGiaNhap.Texts);
            product.TonKho = Convert.ToInt32(tbTonKho.Texts);
            Console.WriteLine(product.MaDM);
            if (tbTrangThai.Texts == "Đang mở bán")
            {
                product.MoBan = true;
            }
            else
            {
                product.MoBan = false;
            }
            product.MoTa = tbMoTa.Text;
            //suaChiTietSPBLL.updateProduct(product);
        }

        private void GrVDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            isClickOnCate = true;
            if (e.RowIndex >= 0) // Kiểm tra dòng click có hợp lệ hay không
            {
                DataGridViewRow clickedRow = GrVDanhMuc.Rows[e.RowIndex];
                string categoryName = clickedRow.Cells[0].Value.ToString();
                tbDanhMuc.Texts = categoryName;
                GrVDanhMuc.Visible = false;
            }
        }

        private void GrVTrangThai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            isClickOnState = true;
            if (e.RowIndex >= 0) // Kiểm tra dòng click có hợp lệ hay không
            {
                DataGridViewRow clickedRow = GrVTrangThai.Rows[e.RowIndex];
                string state = clickedRow.Cells[0].Value.ToString();
                tbTrangThai.Texts = state;
                GrVTrangThai.Visible = false;
            }
        }

        /*click ra ngoài chỗ khác thì gv gợi ý danh mục và gv gợi ý trạng thái sẽ ẩn*/
        private void tbMoTa_Enter(object sender, EventArgs e)
        {
            GrVDanhMuc.Visible = false;
            GrVTrangThai.Visible = false;
        }

        private void tbGiaBan_Enter(object sender, EventArgs e)
        {
            GrVDanhMuc.Visible = false;
            GrVTrangThai.Visible = false;
        }

        private void tbGiaNhap_Enter(object sender, EventArgs e)
        {
            GrVDanhMuc.Visible = false;
            GrVTrangThai.Visible = false;
        }

        private void tbTonKho_Enter(object sender, EventArgs e)
        {
            GrVDanhMuc.Visible = false;
            GrVTrangThai.Visible = false;
        }

        private void tbTenSP_Enter(object sender, EventArgs e)
        {
            GrVDanhMuc.Visible = false;
            GrVTrangThai.Visible = false;
        }
        /*---------------------------------------------*/

    }
}
