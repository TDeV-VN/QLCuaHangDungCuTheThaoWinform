using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class SuaChiTietSPBLL
    {
        private DataTable listDanhMuc;
        private SanPham product;
        public DataTable ListDanhMuc { get => listDanhMuc; set => listDanhMuc = value; }
        public SanPham Product { get => product; set => product = value; }
        public SuaChiTietSPBLL(string maSP)
        {
            ListDanhMuc = new DataTable();
            DatabaseAccess.getListDanhMuc(listDanhMuc);
            Product = DatabaseAccess.GetSanPham(maSP);
        }

        public string getTenDanhMucByMaDM(string maDM)
        {
            return DatabaseAccess.getTenDanhMucByMaDM(maDM);
        }

        public string getAvatarURLSanPham(string maSP)
        {
            return DatabaseAccess.GetAvatarURLSanPham(maSP);
        }

        public List<string> getAllNonAvatarURLSanPham(string maSP)
        {
            return DatabaseAccess.getAllNonAvatarURLSanPham(maSP);
        }

        public void deleteImage(string maSP, string URL)
        {
            DatabaseAccess.deleteImage(maSP, URL);
        }

        public bool addAvatar(string maSP, string URL)
        { 
            // Lấy URL của ảnh chính hiện tại
            string currentAvatarURL = DatabaseAccess.checkAvatar(maSP);
            // Nếu URL khác rỗng là đã tồn tại ảnh chính
            if (currentAvatarURL != "")
            {
                if (MessageBox.Show($"Bạn có muốn thay ảnh chính không ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Kiểm tra nếu thêm thất bại là do vi phạm khóa chính ở ảnh chính hoặc ảnh phụ
                    if (!DatabaseAccess.addAvatar(maSP, URL))
                    {
                        if (MessageBox.Show($"Đã tồn tại ảnh này ở ảnh chính hoặc ảnh phụ ! Bạn có muốn thay ảnh chính ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            // Xóa ảnh chính và ảnh phụ có thể trùng
                            DatabaseAccess.deleteImage(maSP, URL);
                            DatabaseAccess.deleteAvatar(maSP);
                            // Thêm ảnh mới 
                            DatabaseAccess.addAvatar(maSP, URL);
                            MessageBox.Show("Đã thay ảnh chính thành công !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        // Xóa URL của ảnh chính cũ
                        DatabaseAccess.deleteImage(maSP, currentAvatarURL);
                        MessageBox.Show("Đã thay ảnh chính thành công !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            // Không tồn tại ảnh chính
            else
            {
                if (MessageBox.Show($"Chưa tồn tại ảnh chính .Bạn có muốn thêm ảnh chính không?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Nếu thêm thất bại là do vi phạm khóa chính vì đã tồn tại khóa chính ở ảnh phụ
                    if (!DatabaseAccess.addAvatar(maSP, URL))
                    {
                        if (MessageBox.Show($"Đã tồn tại ảnh này ở ảnh phụ ! Bạn vẫn muốn thay đổi ảnh chính ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            // Cập nhật lại ảnh phụ bị trùng thành ảnh chính
                            DatabaseAccess.updateAvatar(maSP, URL);
                            MessageBox.Show("Đã thêm ảnh chính thành công !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Đã thêm ảnh chính thành công !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            
        }

        public bool updateProduct(SanPham product)
        {
            try
            {
                DatabaseAccess.updateProduct(product);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool addImage(string maSP, string[] URL)
        {
            if (MessageBox.Show($"Bạn có muốn thêm ảnh không ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Kiểm tra nếu thêm thất bại là do vi phạm khóa chính ở ảnh chính hoặc ảnh phụ
                if (!DatabaseAccess.addImage(maSP, URL))
                {
                    MessageBox.Show("Thêm ảnh thất bại. Đã có ảnh bị trùng với ảnh chính hoặc ảnh phụ !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    MessageBox.Show("Đã thêm ảnh thành công !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        public void addImageForAdd(string maSP, string[] URL)
        {
            DatabaseAccess.addImage(maSP, URL);
        }

        public void addAvatarForAdd(string maSP, string URL)
        {
            DatabaseAccess.addAvatar(maSP, URL);
        }

        public void addSanPham(SanPham product)
        {
            DatabaseAccess.addSanPham(product);
        }

        public string getLastProductID()
        {
            return DatabaseAccess.getLastProductID();
        }
    }
}
