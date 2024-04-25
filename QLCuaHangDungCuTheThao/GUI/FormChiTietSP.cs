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
    public partial class FormChiTietSP : Form
    {
        public FormChiTietSP()
        {
            InitializeComponent();
            btQuayLai_Click(null, null);
        }
        private FormSuaChiTietSP formSuaChiTietSP = new FormSuaChiTietSP();
        private FormXemChiTietSP formXemChiTietSP = new FormXemChiTietSP();

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSua_Click(object sender, EventArgs e)
        {

            if (btSua.Text == "Sửa")
            {
                bool containsPanel = panel12.Controls.ContainsKey("panelChiTietSP");
                if (containsPanel) panel12.Controls.RemoveByKey("panelChiTietSP");
                Panel panelSuaChiTietSP = formSuaChiTietSP.PanelSuaChiTietSP;
                panelSuaChiTietSP.Location = new Point(0, 71);
                panel12.Controls.Add(panelSuaChiTietSP);
                btSua.Text = "Lưu";
                btXoa.Visible = false;
                btQuayLai.Visible = true;
                lbHeader.Text = "Sửa thông tin sản phẩm";
            } else //Lưu
            {
                bool containsPanel = panel12.Controls.ContainsKey("panelSuaChiTietSP");
                if (containsPanel) panel12.Controls.RemoveByKey("panelSuaChiTietSP");
                Panel panelXemChiTietSP = formXemChiTietSP.PanelXemChiTietSP;
                panelXemChiTietSP.Location = new Point(0, 71);
                panel12.Controls.Add(panelXemChiTietSP);
                btSua.Text = "Sửa";
                btXoa.Visible = true;
                btQuayLai.Visible = false;
                lbHeader.Text = "Thông tin sản phẩm";
            }
            
        }

        private void btQuayLai_Click(object sender, EventArgs e)
        {
            bool containsPanel = panel12.Controls.ContainsKey("panelSuaChiTietSP");
            if (containsPanel) panel12.Controls.RemoveByKey("panelSuaChiTietSP");
            Panel panelXemChiTietSP = formXemChiTietSP.PanelXemChiTietSP;
            panelXemChiTietSP.Location = new Point(0, 71);
            panel12.Controls.Add(panelXemChiTietSP); //Panel được thêm vào sau câu lệnh này không có tên panelXemChiTietSP mà là panelChiTietSP
            btSua.Text = "Sửa";
            btXoa.Visible = true;
            btQuayLai.Visible = false;
            lbHeader.Text = "Thông tin sản phẩm";
        }
    }
}
