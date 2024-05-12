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
    public partial class FormXemChiTietSP : Form
    {
        int indexImage = 0;
        string urlAvatar;
        List<string> urlNonAvatar;
        public XemChiTietSPBLL xemChiTietSPBLL;
        SanPham product;
        DataTable category;
        private FormSuaChiTietSP formSuaChiTietSP;
        public FormXemChiTietSP(string maSP)
        {
            xemChiTietSPBLL = new XemChiTietSPBLL(maSP);
            formSuaChiTietSP = new FormSuaChiTietSP(maSP);
            product = xemChiTietSPBLL.Product;
            category = xemChiTietSPBLL.ListDanhMuc;
            urlAvatar = xemChiTietSPBLL.getAvatarURLSanPham(product.MaSP);
            urlNonAvatar = xemChiTietSPBLL.getAllNonAvatarURLSanPham(product.MaSP);
            InitializeComponent();
            tbMaSP.Enabled = false;
            tbTenSP.Enabled = false;
            tbDanhMuc.Enabled = false;
            tbGiaNhap.Enabled = false;
            tbGiaBan.Enabled = false;
            tbTonKho.Enabled = false;
            tbTrangThai.Enabled = false;
            tbMoTa.ReadOnly = true;
            tbMoTa.ScrollBars = ScrollBars.Vertical;
            formChiTietSP_Load(null, null);
        }
        public Panel PanelXemChiTietSP
        {
            get { return panelChiTietSP; }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void updateInformationDisplay(SanPham prod, string urlAvatar, List<string> urlImg)
        {
            product = prod;
            updateImg(urlAvatar, urlImg);
            formChiTietSP_Load(null, null);
        } 

        public void updateImg(string urlAvatar, List<string> urlImg)
        {
            this.urlAvatar = urlAvatar;
            this.urlNonAvatar = urlImg; 
            if (urlAvatar != "")
            {
                picBox.Image = Image.FromFile(urlAvatar);
            }
            else
            {
                picBox.Image = null;
            }
        }

        private void formChiTietSP_Load(object sender, EventArgs e)
        {
            tbMaSP.Texts = product.MaSP;
            tbTenSP.Texts = product.TenSP;
            tbDanhMuc.Texts = xemChiTietSPBLL.getTenDanhMucByMaDM(product.MaDM);
            tbGiaNhap.Texts = Convert.ToString(product.GiaNhap);
            tbGiaBan.Texts = Convert.ToString(product.GiaBan);
            tbTonKho.Texts = Convert.ToString(product.TonKho);
            if(product.MoBan)
            {
                tbTrangThai.Texts = "Đang mở bán";
            }
            else
            {
                tbTrangThai.Texts = "Dừng bán";
            }
            tbMoTa.Text = product.MoTa;
            if (urlAvatar != "")
            {
                picBox.Image = Image.FromFile(urlAvatar);
            }
            else
            {
                picBox.Image = null;
            }
       
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            formSuaChiTietSP.updateProduct();
            Panel panelSuaChiTietSP = formSuaChiTietSP.PanelSuaChiTietSP;
            panelSuaChiTietSP.Location = new Point(0, 71);
            this.Controls.Add(panelSuaChiTietSP);
        }

        private void btPicLeft_Click(object sender, EventArgs e)
        {
            indexImage = (indexImage + urlNonAvatar.Count) % (urlNonAvatar.Count + 1);
            if (indexImage == 0)
            {
                if (urlAvatar == "")
                {
                    picBox.Image = null;
                }
                else
                {
                    picBox.Image = Image.FromFile(urlAvatar);
                }
            }
            else
            {
                picBox.Image = Image.FromFile(urlNonAvatar[indexImage - 1]);
            }
            picBox.Refresh();
        }

        private void btPicRight_Click(object sender, EventArgs e)
        {
            indexImage = (indexImage + 1) % (urlNonAvatar.Count + 1);
            if(indexImage == 0)
            {
                if(urlAvatar == "")
                {
                    picBox.Image = null;
                }
                else
                {
                    picBox.Image = Image.FromFile(urlAvatar);
                }
            }
            else
            {
                picBox.Image = Image.FromFile(urlNonAvatar[indexImage-1]);
            }
            picBox.Refresh();
        }
    }
}
