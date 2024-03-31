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
    public partial class FormPhieuThu : Form
    {
        public FormPhieuThu()
        {
            InitializeComponent();
        }
        public Panel PanelPagePhieuThu
        {
            get
            {
                return panelPagePhieuThu;
            }
        }
    }
}
