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
using System.Windows.Input;

namespace GUI
{
    public partial class FormXacThucGiaoDich : Form
    {
        private Timer timer1 = new Timer(); // chờ cho dữ liệu được cập nhật vào sheet
        private Timer timer2 = new Timer(); // khoảng thời gian chờ để xác thực giao dịch
        private Timer timer3 = new Timer(); // khoảng cách giữa các lần đọc sheet;
        private int soTien;
        private string noiDungCK;
        public FormXacThucGiaoDich(string mahd, int soTien)
        {
            InitializeComponent();
            this.soTien = soTien;
            this.noiDungCK = mahd;
            timer1.Interval = 30000; //30s
            timer1.Tick += xacThuc;
            timer2.Interval = 300000; // 5 phút
            timer2.Tick += huyGiaoDich;
            timer3.Interval = 10000; // 3 giây
            timer3.Tick += docSheet;
            timer1.Start();
        }

        private void xacThuc(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Start();
            timer3.Start();
        }

        private void huyGiaoDich(object sender, EventArgs e)
        {
            timer2.Stop();
            timer3.Stop();
            picCho.Visible = false;
            picThatBai.Visible = true;
            lbThatBai.Visible = true;
        }

        private async void giaoDichThanhCong(object sender, EventArgs e)
        {
            timer2.Stop();
            picCho.Visible = false;
            picThanhCong.Visible = true;
            lbThanhCong.Visible = true;
            await Task.Delay(5000); //delay 5s rồi mới đóng form
            this.DialogResult = DialogResult.Yes;
        }

        private void docSheet(object sender, EventArgs e)
        {
            timer3.Stop();
            //đọc dữ liệu từ sheet
            
            string mota = Payment.readDataFromGoogleSheet(1, 1).Trim();
            if (mota == noiDungCK)
            {
                string soTienNhanStr = Payment.readDataFromGoogleSheet(1, 2).Trim().Replace(".", "");
                int soTienNhan = int.Parse(soTienNhanStr);
                if (soTienNhan == soTien)
                {
                    giaoDichThanhCong(sender, e);
                    return;
                }
                else
                {
                    MessageBox.Show("Số tiền không khớp!");
                    huyGiaoDich(sender, e);
                }
            } else
            {
                timer3.Start();
            }

        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn lưu hóa đơn bỏ qua việc xác thực giao dịch?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) this.DialogResult = DialogResult.Yes;
        }

        private void btDoi_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            this.DialogResult = DialogResult.No;
        }
    }
}
