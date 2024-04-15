﻿using System;
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
            tbEmail.Focus();
            formOTP.XacThuc += formOTP_btXacThuc_Click;
        }

        static private FormOTP formOTP = new FormOTP();
        static private FormDatLaiMatKhau formDatLaiMatKhau = new FormDatLaiMatKhau();
        static private Panel panelDatLaiMatKhau = formDatLaiMatKhau.PanelDatLaiMatKhau;
        static private Panel panelOTP = formOTP.PanelOTP;
/*-------------------------------SỰ KIỆN------------------------------------------------------*/
        private void btDangNhap_Click(object sender, EventArgs e)
        {

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
                panelDangNhap.Location = new Point(76, 67);
                this.Controls.Add(panelOTP);
            } else if (this.Controls.Contains(panelOTP))
            {
                this.Controls.Remove(panelOTP);
                panelDatLaiMatKhau.Location = new Point(76, 67);
                this.Controls.Add(panelDangNhap);
            }
        }

        private void lbQuenMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Controls.Remove(panelDangNhap);
            panelDatLaiMatKhau.Location = new Point(76, 67);
            this.Controls.Add(panelOTP);
            
        }
/*-----------------------------HÀM--------------------------*/
        //Xử lý sự kiện xác thực OTP từ formOTP
        private void formOTP_btXacThuc_Click(string otp)
        {
            //Check OTP

            //Nếu đúng
            this.Controls.Remove(panelOTP);
            panelDatLaiMatKhau.Location = new Point(76, 67);
            this.Controls.Add(panelDatLaiMatKhau);
        }
    }
}
