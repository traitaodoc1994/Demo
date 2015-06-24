using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLBanhang
{
    public partial class Huongdan : Form
    {
        public Huongdan()
        {
            InitializeComponent();
        }

        private void Huongdan_Load(object sender, EventArgs e)
        {
            hd.Text = "Các phím tắt trên thanh menu: "+
                "\n -Sách: Ctrl + S" + "\n -Nhà xuất bản: Ctrl + N" + "\n -Nhân viên: Ctrl + V"+
                "\n -Khách hàng: Ctrl + K" + "\n -Hóa đơn: Ctrl + H" + "\n -Danh sách sách: Alt+1"+
                "\n -Danh sách nhà xuất bản: Alt+2"+
                "\n -Danh sách nhân viên: Alt+3" +
                "\n -Danh sách khách hàng: Alt+4" +
                "\n -Giới thiệu phần mềm: Ctrl+G" +
                "\n -Hướng dẫn sử dụng: Ctrl+R" +
                "\nNhập dữ liệu vào các ô tương ứng và ấn các nút chức năng để thực hiện thao tác thêm, sửa, xóa, tìm kiếm,..."+
                "\nHướng dẫn nhập dữ liệu đúng cách:"+
                "\n -Các trường Mã chỉ được nhập ký tự không có dấu"+
                "\n -Các trường như họ tên, tên sách, tác giả thì được nhập ký tự có dấu"+
                "\n -Các trường số điện thoại, số CMND chỉ được nhập số";
        }


    }
}
