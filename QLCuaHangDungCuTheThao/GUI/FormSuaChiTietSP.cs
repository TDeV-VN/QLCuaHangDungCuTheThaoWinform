using BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace GUI
{
    public partial class FormSuaChiTietSP : Form
    {
        bool isClickOnCate = false;
        bool isClickOnState = false;
        public string urlAvatar;
        public List<string> urlNonAvatar;
        private SuaChiTietSPBLL suaChiTietSPBLL;
        public SanPham product;
        DataTable category;
        public FormSuaChiTietSP(string maSP)
        {
            suaChiTietSPBLL = new SuaChiTietSPBLL(maSP);
            product = suaChiTietSPBLL.Product;
            category = suaChiTietSPBLL.ListDanhMuc;
            urlAvatar = suaChiTietSPBLL.getAvatarURLSanPham(product.MaSP);
            urlNonAvatar = suaChiTietSPBLL.getAllNonAvatarURLSanPham(product.MaSP);
            InitializeComponent();
            formSuaChiTietSP_Load();
            populateImages();
            tbMoTa.ScrollBars = ScrollBars.Vertical;
            GrVTrangThai.ScrollBars = ScrollBars.None;
        }
        
        public Panel PanelSuaChiTietSP
        {
            get 
            {
                GrVTrangThai.Visible = false;
                GrVDanhMuc.Visible = false;
                if (product.MoBan)
                {
                    tbTrangThai.Texts = "Đang mở bán";
                }
                else
                {
                    tbTrangThai.Texts = "Dừng bán";
                }
                return panelSuaChiTietSP; 
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

        private void tbTrangThai__TextChanged(object sender, EventArgs e)
        {
            if (isClickOnState)
            {
                isClickOnState = false;
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
            foreach(DataRow cate in suaChiTietSPBLL.ListDanhMuc.Rows)
            {
                cateName.Rows.Add(cate["TenDM"].ToString());
            }
            GrVDanhMuc.DataSource = cateName;
            GrVDanhMuc.Visible = true;
        }

        public void populateImages()
        {
            // Thêm ảnh chính, tên file ảnh chính
            if(urlAvatar != "")
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
                try
                {
                    lstImg[i].Icon = System.Drawing.Image.FromFile(urlNonAvatar[i]);
                }
                catch
                {
                    lstImg[i].Icon = null;
                }
                lstImg[i].FileName = getBriefFileName(urlNonAvatar[i]);
                lstImg[i].BtnDel.Click += ListImageButtonDelete_Click;
                flowLayoutPanel1.Controls.Add(lstImg[i]);
            }
        }

        public string getBriefFileName(string name)
        {
            name = Path.GetFileName(name);
            if(name.Length > 14)
            {
                name = name.Substring(0, 14) + "...";
            }
            return name;
        }

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
        public void updateProduct()
        {
            product.TenSP = tbTenSP.Texts;
            foreach(DataRow dr in category.Rows)
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
            suaChiTietSPBLL.updateProduct(product);
        }
        public void formSuaChiTietSP_Load()
        {
            tbMaSP.Enabled = false;
            tbMaSP.Texts = product.MaSP;
            tbTenSP.Texts = product.TenSP;
            tbDanhMuc.Texts = suaChiTietSPBLL.getTenDanhMucByMaDM(product.MaDM);
            tbGiaBan.Texts = Convert.ToString(product.GiaBan);
            tbGiaNhap.Texts = Convert.ToString(product.GiaNhap);
            tbTonKho.Texts = Convert.ToString(product.TonKho);
            if (product.MoBan)
            {
                tbTrangThai.Texts = "Đang mở bán";
            }
            else
            {
                tbTrangThai.Texts = "Dừng bán";
            }
            tbMoTa.Text = product.MoTa;
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
        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg;*.jpeg;*.png";
            // Cho phép chọn nhiều ảnh
            dialog.Multiselect = true;
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                if(suaChiTietSPBLL.addImage(product.MaSP, dialog.FileNames))
                {
                    // Tạo lại danh sách hình ảnh
                    urlNonAvatar = suaChiTietSPBLL.getAllNonAvatarURLSanPham(product.MaSP);
                    // Xóa danh sách ảnh hiện tại
                    flowLayoutPanel1.Controls.Clear();
                    populateImages();
                }
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
                if(suaChiTietSPBLL.addAvatar(product.MaSP, dialog.FileName))
                {
                    urlAvatar = dialog.FileName;
                    if(panelAvatar.Controls.Count > 0)
                    {
                        panelAvatar.Controls.RemoveAt(0);
                    }
                    
                    // Chỉ thêm mới ảnh chính, không thêm các ảnh phụ ( vì đã thêm từ đầu )
                    urlNonAvatar = suaChiTietSPBLL.getAllNonAvatarURLSanPham(product.MaSP);
                    flowLayoutPanel1.Controls.Clear();
                    // Xóa ảnh phụ trùng với ảnh chính vừa thêm
                    
                    populateImages();
                }
                
            }
        }

        private void tbGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void tbGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void tbTonKho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

    }
}
