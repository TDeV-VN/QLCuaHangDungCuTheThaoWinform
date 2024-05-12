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
        public string urlAvatar = "";
        public List<string> urlNonAvatar = new List<string>();
        DataTable category;
        private SanPham product = new SanPham();
        private SuaChiTietSPBLL suaChiTietSPBLL = new  SuaChiTietSPBLL("");
        string lastProductID;
        public FormThemSP()
        {
            InitializeComponent();
            lastProductID = suaChiTietSPBLL.getLastProductID();
            category = suaChiTietSPBLL.ListDanhMuc;
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
                isClickOnState = false;
                return;
            }
            else
            {
                tbTrangThai.Texts = "Đang mở bán";
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
                tbDanhMuc.Texts = "";
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

        private void setCategoryIDForProd(string name)
        {
            foreach (DataRow dr in category.Rows)
            {
                if (dr["TenDM"].ToString() == name)
                {
                    product.MaDM = dr["MaDM"].ToString();
                    break;
                }
            }
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
                urlAvatar = "";
            }
        }

        private string isOverlapImage(string url)
        {
            if(urlNonAvatar.Contains(url))
            {
                return "ExistInImage";
            }
            else if(url == urlAvatar)
            {
                return "ExistInAvatar";
            }
            return "NonExist";
        }

        private void btnAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg;*.jpeg;*.png";
            // Chỉ được chọn 1 ảnh
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string checkExist = isOverlapImage(dialog.FileName);
                if(checkExist == "NonExist")
                {
                    urlAvatar = dialog.FileName;
                }
                else if(checkExist == "ExistInImage")
                {
                    MessageBox.Show("Đã tồn tại ảnh này ở ảnh phụ. Vui lòng xóa ở ảnh phụ trước khi thêm !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if(checkExist == "ExistInAvatar")
                {
                    return;
                }
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
            bool isOverlap = false;
            bool isAdded = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // Tạo lại danh sách hình ảnh
                string[] fileNames = dialog.FileNames;
                for(int i = 0; i < fileNames.Length; i++)
                {
                    if (isOverlapImage(fileNames[i]) == "NonExist")
                    {
                        urlNonAvatar.Add(fileNames[i]);
                        isAdded = true;
                    }
                    else if (isOverlapImage(fileNames[i]) == "ExistInImage")
                    {
                        isOverlap = true;
                    }
                    else
                    {
                        isOverlap = true;
                    }
                }
                if(isOverlap)
                {
                    if(isAdded)
                    {
                        MessageBox.Show("Đã thêm ảnh không trùng lặp vào ảnh phụ !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không thêm được ảnh. Đã có ảnh trùng với ảnh chính hoặc ảnh phụ !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Đã thêm ảnh vào ảnh phụ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // Xóa danh sách ảnh hiện tại
                flowLayoutPanel1.Controls.Clear();
                populateImages();
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
        // set to default
        private void setTextBoxesToDefault()
        {
            isClickOnCate = true;
            isClickOnState = true;

            tbDanhMuc.Texts = string.Empty;
            tbGiaBan.Texts = string.Empty;
            tbGiaNhap.Texts = string.Empty;
            tbTrangThai.Texts = string.Empty;
            tbMoTa.Text = string.Empty;
            tbTenSP.Texts = string.Empty;
            tbTonKho.Texts = string.Empty;
            urlAvatar = "";
            urlNonAvatar.Clear();
            flowLayoutPanel1.Controls.Clear();
            panelAvatar.Controls.Clear();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if(tbDanhMuc.Texts == "" || tbGiaBan.Texts == "" || tbGiaNhap.Texts == "" || tbTenSP.Texts == "" || tbTonKho.Texts == "" || tbTrangThai.Texts == "") 
            {
                MessageBox.Show("Nhập thiếu thông tin. Vui lòng kiểm tra !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            product.TenSP = tbTenSP.Texts;
            if(tbTrangThai.Texts == "Đang mở bán")
            {
                product.MoBan = true;
            }
            else
            {
                product.MoBan = false;
            }
            // product.MaDM = CategoryID
            setCategoryIDForProd(tbDanhMuc.Texts);
            product.MoTa = tbMoTa.Text;
            product.GiaBan = Convert.ToInt32(tbGiaBan.Texts);
            product.GiaNhap = Convert.ToInt32(tbGiaNhap.Texts);
            product.TonKho = Convert.ToInt32(tbTonKho.Texts);

            if (MessageBox.Show($"Bạn chắc chắn muốn thêm sản phẩm này ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                suaChiTietSPBLL.addSanPham(product);
                if (urlAvatar != "")
                {
                    suaChiTietSPBLL.addAvatarForAdd(lastProductID, urlAvatar);
                }
                if (urlNonAvatar.Count != 0)
                {
                    suaChiTietSPBLL.addImageForAdd(lastProductID, urlNonAvatar.ToArray());
                }
                MessageBox.Show("Thêm sản phẩm thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                setTextBoxesToDefault();
            }
        }
    }
}
