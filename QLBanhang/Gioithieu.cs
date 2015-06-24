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
    public partial class Gioithieu : Form
    {
        public Gioithieu()
        {
            InitializeComponent();
        }

        private void Gioithieu_Load(object sender, EventArgs e)
        {
            About.Text = "Phần mềm quản lý bán sách được viết cho cửa hàng sách Odyssey"+
                "\nNhóm lập trình phần mềm:" + "\n-Nguyễn Thành Trung" + "\n Nguyễn Đức Duy"+
                "\n-Lại Thị Tuyến"+"\n-Đặng Thị Mỵ"+"\nMô tả chức năng của phần mềm"+
                "\n-Phần mềm quản lý các hạng mục: Khách hàng, Nhân viên, Hóa đơn, Sách, Nhà xuất bản"+
                "\n-Mỗi hạng mục đều có chức năng thêm, sửa, xóa, tìm kiếm";
        }


    }
}
