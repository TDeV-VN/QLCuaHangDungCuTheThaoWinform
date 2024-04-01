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
            lbSaiSDT.Visible = false;
            tbSDT.Focus();
        }

        private void tbSDT__TextChanged(object sender, EventArgs e)
        {

        }

        private void tbMatKhau__TextChanged(object sender, EventArgs e)
        {

        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
