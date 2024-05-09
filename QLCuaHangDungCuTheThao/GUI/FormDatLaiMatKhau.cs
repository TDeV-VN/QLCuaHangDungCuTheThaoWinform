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
    public partial class FormDatLaiMatKhau : Form
    {
        //Phục vụ cho việc xử lý sự kiện btXacThuc_Click ở FormDangNhap
        public delegate void datLaiMK();
        public event datLaiMK DatLaiMK;

        public FormDatLaiMatKhau()
        {
            InitializeComponent();
        }

        public Panel PanelDatLaiMatKhau
        {
            get
            {
                lbSaiDinhDang.Visible = false;
                lbKhongKhop.Visible = false;
                return panelDatLaiMatKhau;
            }
        }

        private void btDatLai_Click(object sender, EventArgs e)
        {
            if (tbMatKhau.Texts.Length < 8)
            {
                lbSaiDinhDang.Visible = true;
                lbKhongKhop.Visible = false;
            } else if (tbMatKhau.Texts != tbXacNhanMK.Texts)
            {
                lbSaiDinhDang.Visible = false;
                lbKhongKhop.Visible = true;
            } else
            {
                lbSaiDinhDang.Visible = false;
                lbKhongKhop.Visible = false;
                if (TaiKhoanBLL.datLaiMatKhau(tbMatKhau.Texts))
                {
                    MessageBox.Show("Đặt lại mật khẩu thành công!"); 
                    DatLaiMK?.Invoke();
                } else
                {
                    MessageBox.Show("Đặt lại mật khẩu thất bại!");
                }
            }
        }
    }
}
