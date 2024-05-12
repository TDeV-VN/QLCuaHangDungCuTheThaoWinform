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
            timer1.Interval = 5000;//60000; //1 phút
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
            MessageBox.Show("Giao dịch thất bại!");
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void giaoDichThanhCong(object sender, EventArgs e)
        {
            timer2.Stop();
            MessageBox.Show("Giao dịch thành công!");
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void docSheet(object sender, EventArgs e)
        {
            timer3.Stop();
            //đọc dữ liệu từ sheet
            
            string mota = Payment.readDataFromGoogleSheet(1, 1).Trim();
            if (mota == noiDungCK)
            {
                string soTienNhanStr = Payment.readDataFromGoogleSheet(1, 2).Trim().Replace(".", "");
                //test
                MessageBox.Show("sotienstr: " + soTienNhanStr);

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


    }
}
