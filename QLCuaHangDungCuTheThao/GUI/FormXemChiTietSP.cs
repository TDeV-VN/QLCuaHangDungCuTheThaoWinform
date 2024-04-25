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
    public partial class FormXemChiTietSP : Form
    {
        public FormXemChiTietSP()
        {
            InitializeComponent();
            tbMaSP.Enabled = false;
            tbTenSP.Enabled = false;
            tbDanhMuc.Enabled = false;
            tbGiaNhap.Enabled = false;
            tbGiaBan.Enabled = false;
            tbTonKho.Enabled = false;
            tbTrangThai.Enabled = false;
            tbMoTa.ReadOnly = true;
            tbMoTa.ScrollBars = ScrollBars.Vertical;
            formChiTietSP_Load(null, null);
        }
        public Panel PanelXemChiTietSP
        {
            get { return panelChiTietSP; }
        }
        private FormSuaChiTietSP formSuaChiTietSP = new FormSuaChiTietSP();

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formChiTietSP_Load(object sender, EventArgs e)
        {
            tbMaSP.Texts = "SP001";
            tbTenSP.Texts = "Vợt cầu lông Yonex Exforce Cannon - Đen";
            tbDanhMuc.Texts = "Vợt cầu lông";
            tbGiaNhap.Texts = "10,000,000 VNĐ";
            tbGiaBan.Texts = "11,000,000 VNĐ";
            tbTonKho.Texts = "10";
            tbTrangThai.Texts = "Mở bán";
            tbMoTa.Text = "1. Giới thiệu Vợt cầu lông Lining Axforce Cannon - Đen (Nội địa Trung)\r\nĐược ra mắt đầu năm 2023 với hai phiên bản màu trắng và đen cùng hai phong thái hoàn toàn đối lập, nếu phiên bản màu trắng nhẹ nhàng và tinh tế thì với cây Lining Axforce Cannon với nước sơn đen cá tính điểm các chi tiết màu sắc nhỏ nhưng rất bắt mắt trên thân vợt mang tới vẻ huyền bí và thu hút cho các lông thủ trên sân cầu.\r\n\r\nVợt cầu lông Lining Axforce Cannon - Đen (Nội địa Trung) có 2 phiên bản 4U và 5U, chu vi cán vợt G6, đường kính đũa vợt 7mm, mức căng tối đa 31LBS là các thông số cơ bản của vợt cầu lông Lining Axforce Cannon Đen Nội địa Trung.\r\n\r\nĐộ cứng thân vợt ở mức trung bình phù hợp với nhiều đối tượng kể cả người mới chơi, học sinh sinh viên với lực cổ tay không quá tốt đều có thể thuần được cây vợt này. Với thiết kế nặng đầu cây vợt Lining Axforce Cannon Đen Nội địa Trung phù hợp với lối chơi tấn công, cho những pha đập cầu cắm sân đầy uy lực.";
            picBox.Image = Image.FromFile("E:\\imgWinform\\votyonex.jpeg");
       
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            Panel panelSuaChiTietSP = formSuaChiTietSP.PanelSuaChiTietSP;
            panelSuaChiTietSP.Location = new Point(0, 71);
            this.Controls.Add(panelSuaChiTietSP);
        }
    }
}
