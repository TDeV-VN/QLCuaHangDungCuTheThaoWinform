using BLL;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormOTP : Form
    {
        //Phục vụ cho việc xử lý sự kiện btXacThuc_Click ở FormDangNhap
        public delegate void xacThuc();
        public event xacThuc XacThuc;
        private string otp;
        private Timer timer = new Timer();

        public FormOTP()
        {
            InitializeComponent();
            timer.Interval = 300000; //thời hiệu lực của mã OTP là 5 phút
            timer.Tick += huyOTP;
        }

        public Panel PanelOTP
        {
            get
            {
                lbSaiEmail.Visible = false;
                lbSaiMa.Visible = false;
                lbGuiLaiMa.Visible = false;
                lbKtraEmail.Visible = false;
                return panelOTP;
            }
        }

        private void btGuiMa_Click(object sender, EventArgs e)
        {
            //kiểm tra định dạng email
            if (!TaiKhoanBLL.kiemTraDinhDangEmail(tbEmail.Texts))
            {
                MessageBox.Show("Định dạng mail không hợp lệ!");
                return;
            }
            //kiểm tra email có tồn tại trong hệ thống không
            if (!TaiKhoanBLL.kiemTraEmailTonTai(tbEmail.Texts))
            {
                lbSaiEmail.Visible = true;
                return;
            }else
            {
                lbSaiEmail.Visible = false;
            }
            //gửi mã OTP
            otp = TaiKhoanBLL.guiOTP(tbEmail.Texts);
            if (otp != null)
            {
                timer.Start();
                lbKtraEmail.Visible = true;
                lbGuiLaiMa.Visible = true;
                tbMa.Texts = "";
                lbSaiEmail.Visible = false;
                lbSaiMa.Visible = false;
                btGuiMa.Enabled = false;
                TaiKhoanBLL.TaiKhoan.Email = tbEmail.Texts;
            } else
            {
                MessageBox.Show("Gửi mã thất bại!");
            }
        }

        private void btXacThuc_Click(object sender, EventArgs e)
        {
            if (tbMa.Texts == otp)
            {
                XacThuc?.Invoke(); // Xử lý ở FormDangNhap
            } else
            {
                lbSaiMa.Visible = true;
            }
        }

        private void tbEmail__TextChanged(object sender, EventArgs e)
        {
            huyOTP(null, null);
        }

        public void huyOTP(object sender, EventArgs e)
        {
            timer.Stop();
            otp = null;
            tbMa.Texts = "";
            lbGuiLaiMa.Visible = false;
            lbKtraEmail.Visible = false;
            btGuiMa.Enabled = true;
        }

        private void lbGuiLaiMa_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            huyOTP(null, null);
            btGuiMa_Click(null, null);
        }
    }
}
