using FontAwesome.Sharp;
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
    public partial class ListImage : UserControl
    {
        private Image _icon;
        private string _fileName;
        private IconButton _btnDel;
        public ListImage()
        {
            InitializeComponent();
            BtnDel = btnDelete;
        }
        
        [Category("Custom Props")]
        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; lbFileName.Text = value; }
        }

        [Category("Custom Props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; picBox.Image = value; }
        }

        [Category("Custom Props")]
        public IconButton BtnDel
        {
            get { return _btnDel; }
            set { _btnDel = value; }
        }

        private void ListImage_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.ControlLight;
        }

        private void ListImage_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }
    }
}
