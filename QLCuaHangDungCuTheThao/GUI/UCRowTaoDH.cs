using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GUI.QLCuaHangDungCuTheThao;

namespace GUI
{
    public partial class UCRowTaoDH : UserControl
    {
        public UCRowTaoDH()
        {
            InitializeComponent();
            btXoa.Click += btXoa_Click;
            tbSoLuong.Leave += tbSoLuong_Leave;
            tbSoLuong.TextChanged += tbSoLuong_TextChanged;
        }

        //Tạo sự kiện tùy chỉnh click cho button xóa được click
        public event EventHandler BtXoaClicked;
        private void btXoa_Click(object sender, EventArgs e)
        {
            BtXoaClicked?.Invoke(this, e);
        }

        //Sự kiện textbox số lượng mất focus (Bấm ra ngoài thì mất con trỏ)
        private void tbSoLuong_Leave(object sender, EventArgs e)
        {
            this.Focus();
        }

        //Tạo sự kiện tùy chỉnh khi textbox số lượng thay đổi
        public event EventHandler tbSoLuongChanged;
        private void tbSoLuong_TextChanged(object sender, EventArgs e)
        {
            tbSoLuongChanged?.Invoke(this, e);
        }


        //Properties
        public string STT
        {
            get { return lbSTT.Text; }
            set { lbSTT.Text = value; }
        }
        public string MaSP
        {
            get { return lbMaSP.Text; }
            set { lbMaSP.Text = value; }
        }

        public string TenSP
        {
            get { return lbTenSP.Text; }
            set { lbTenSP.Text = value; }
        }
        
        public string DonGia
        {
            get { return lbDonGia.Text; }
            set { lbDonGia.Text = value; }
        }

        public string SoLuong
        {
            get { return tbSoLuong.Text; }
            set { tbSoLuong.Text = value; }
        }
        public string ThanhTien
        {
            get { return lbThanhTien.Text; }
            set { lbThanhTien.Text = value; }
        }

        public Button BtXoa
        {
            get { return btXoa; }
        }
    }
}
