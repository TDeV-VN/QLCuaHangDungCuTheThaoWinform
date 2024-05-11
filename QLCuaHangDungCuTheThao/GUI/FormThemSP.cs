using BLL;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.IO;

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
        //hiển thị các ảnh
        public void populateImages()
        {
            // Thêm ảnh chính, tên file ảnh chính
            if (urlAvatar != "")
            {
                ListImage avatar = new ListImage();
                avatar.Icon = System.Drawing.Image.FromFile(urlAvatar);
                avatar.FileName = getBriefFileName(urlAvatar);
                avatar.BtnDel.Click += AvatarButtonDelete_Click;
                panelAvatar.Controls.Add(avatar);
            }

            // Thêm các ảnh phụ, tên file ảnh phụ
            ListImage[] lstImg = new ListImage[urlNonAvatar.Count];
            for (int i = 0; i < lstImg.Length; i++)
            {
                lstImg[i] = new ListImage();
                lstImg[i].Icon = System.Drawing.Image.FromFile(urlNonAvatar[i]);
                lstImg[i].FileName = getBriefFileName(urlNonAvatar[i]);
                lstImg[i].BtnDel.Click += ListImageButtonDelete_Click;
                flowLayoutPanel1.Controls.Add(lstImg[i]);
            }
        }
        //thu ngắn tên file ảnh
        public string getBriefFileName(string name)
        {
            name = Path.GetFileName(name);
            if (name.Length > 14)
            {
                name = name.Substring(0, 14) + "...";
            }
            return name;
        }
        //xóa ảnh phụ
        private void ListImageButtonDelete_Click(object sender, EventArgs e)
        {
            IconButton clickedButton = (IconButton)sender;
            int imageIndex = flowLayoutPanel1.Controls.IndexOf(clickedButton.Parent);

            if (imageIndex >= 0 && imageIndex < urlNonAvatar.Count)
            {
                string deletedFileName = Path.GetFileName(urlNonAvatar[imageIndex]);
                if (MessageBox.Show($"Bạn có muốn xóa file ảnh {deletedFileName} không ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    flowLayoutPanel1.Controls.RemoveAt(imageIndex);
                    suaChiTietSPBLL.deleteImage(product.MaSP, urlNonAvatar[imageIndex]);
                    urlNonAvatar.RemoveAt(imageIndex);
                }
            }
        }
        //xóa ảnh chính
        private void AvatarButtonDelete_Click(object sender, EventArgs e)
        {
            IconButton clickedButton = (IconButton)sender;
            string deletedFileName = Path.GetFileName(urlAvatar);
            if (MessageBox.Show($"Bạn có muốn xóa file ảnh {deletedFileName} khỏi ảnh chính không?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                panelAvatar.Controls.RemoveAt(0);
                suaChiTietSPBLL.deleteImage(product.MaSP, urlAvatar);
                urlAvatar = "";
            }
        }

        private void btnAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg;*.jpeg;*.png";
            // Chỉ được chọn 1 ảnh
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                urlAvatar = dialog.FileName;
                if (panelAvatar.Controls.Count > 0)
                {
                    panelAvatar.Controls.RemoveAt(0);
                }

                flowLayoutPanel1.Controls.Clear();
                // Xóa ảnh phụ trùng với ảnh chính vừa thêm

                populateImages();
           

            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg;*.jpeg;*.png";
            // Cho phép chọn nhiều ảnh
            dialog.Multiselect = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // Tạo lại danh sách hình ảnh
                urlNonAvatar.AddRange(dialog.FileNames);
                // Xóa danh sách ảnh hiện tại
                flowLayoutPanel1.Controls.Clear();
                populateImages();
            }
        }
    }
}
