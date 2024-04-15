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
    public partial class FormOTP : Form
    {
        //Phục vụ cho việc xử lý sự kiện btXacThuc_Click ở FormDangNhap
        public delegate void xacThuc(string otp);
        public event xacThuc XacThuc;

        public FormOTP()
        {
            InitializeComponent();
        }

        public Panel PanelOTP
        {
            get
            {
                return panelOTP;
            }
        }

        private void lbSaiEmail_Click(object sender, EventArgs e)
        {

        }

        private void btGuiMa_Click(object sender, EventArgs e)
        {

        }


        private void btXacThuc_Click(object sender, EventArgs e)
        {
            XacThuc?.Invoke(tbMa.Text); // Xử lý ở FormDangNhap
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
