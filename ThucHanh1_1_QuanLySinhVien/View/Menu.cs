using ThucHanh1_1_QuanLySinhVien.Controller;
using System;
using System.Collections.Generic;
using System.Text;

namespace ThucHanh1_1_QuanLySinhVien.View
{
    class Menu
    {
        QuanLySinhVien qlySV; 
        public Menu() // khởi tạo menu cùng một số hàm khác (ctor + tab)
        {
            qlySV = new QuanLySinhVien();
        }
        public void DanhSach()
        {
            int choice = -1;
            do
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1. Nhap Sinh Vien");
                Console.WriteLine("2. Luu danh sach Sinh Vien");
                Console.WriteLine("Xin moi nhap lua chon");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        qlySV.NhapSV();
                        break;
                    case 2:
                        qlySV.LuuSV();
                        break;
                }
            } while (choice != 0);
        }
    }
}
