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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
            tbMatKhau.PasswordChar = true;
            lbSaiMatKhau.Visible = false;
            lbSaiEmail.Visible = false;
            formOTP.XacThuc += formOTP_btXacThucThanhCong;
            formDatLaiMatKhau.DatLaiMK += formDatLaiMatKhau_btDatLaiMK;
        }

        static private FormOTP formOTP = new FormOTP();
        static private FormDatLaiMatKhau formDatLaiMatKhau = new FormDatLaiMatKhau();
        static private Panel panelDatLaiMatKhau = formDatLaiMatKhau.PanelDatLaiMatKhau;
        static private Panel panelOTP = formOTP.PanelOTP;
/*-------------------------------SỰ KIỆN------------------------------------------------------*/
        private void btDangNhap_Click(object sender, EventArgs e)
        {
            if (!TaiKhoanBLL.kiemTraEmailTonTai(tbEmail.Texts))
            {
                lbSaiEmail.Visible = true;
                lbSaiMatKhau.Visible = false;
            } else if (!TaiKhoanBLL.verifyPassword(tbMatKhau.Texts))
            {
                lbSaiMatKhau.Visible = true;
                lbSaiEmail.Visible = false;
            } else if (!TaiKhoanBLL.dangNhap())
            {
                MessageBox.Show("Tài khoản đã bị khóa, vui lòng liên hệ quản lý!");
            } else
            {
                this.Close();
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btQuayLai_Click(object sender, EventArgs e)
        {
            if (this.Controls.Contains(panelDatLaiMatKhau))
            {
                this.Controls.Remove(panelDatLaiMatKhau);
            } else if (this.Controls.Contains(panelOTP))
            {
                this.Controls.Remove(panelOTP);
            }
            panelDangNhap.Location = new Point(76, 67);
            this.Controls.Add(panelDangNhap);
        }

        public void lbQuenMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Controls.Remove(panelDangNhap);
            panelDatLaiMatKhau.Location = new Point(76, 67);
            this.Controls.Add(panelOTP);
            
        }
/*-----------------------------HÀM--------------------------*/
        //Xử lý sự kiện xác thực OTP từ formOTP
        private void formOTP_btXacThucThanhCong()
        {
            this.Controls.Remove(panelOTP);
            panelDatLaiMatKhau = formDatLaiMatKhau.PanelDatLaiMatKhau;
            panelDatLaiMatKhau.Location = new Point(76, 67);
            this.Controls.Add(panelDatLaiMatKhau);
        }

        //Xử lý sự kiện đặt lại mật khẩu từ formDatLaiMatKhau
        private void formDatLaiMatKhau_btDatLaiMK()
        {
            if (!TaiKhoanBLL.dangNhap())
            {
                MessageBox.Show("Tài khoản đã bị khóa, vui lòng liên hệ quản lý!");
            }
            else
            {
                this.Close();
            }
        }

        private void formLoad(object sender, EventArgs e)
        {
            tbEmail.Select();
        }
    }
}
