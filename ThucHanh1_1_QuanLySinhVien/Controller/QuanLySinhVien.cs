using ThucHanh1_1_QuanLySinhVien.Model;
using ThucHanh1_1_QuanLySinhVien.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace ThucHanh1_1_QuanLySinhVien.Controller
{
    class QuanLySinhVien
    {
        // Khai báo đối tượng và list đối tượng
        SinhVien sv;
        List<SinhVien> listSV;

        public QuanLySinhVien() //khi khởi tạo class thì sẽ tạo 1 list sinh viên
        {
            listSV = new List<SinhVien>();
        }

        //Nhập mới sinh viên
        public void NhapSV()
        {
            // khởi tạo sinh viên mỗi lần hàm NhapSV được chạy
            sv = new SinhVien();
            Console.WriteLine("Xin moi nhap MaSV:");
            sv.MaSV = Console.ReadLine();
            Console.WriteLine("Xin moi nhap ten SV:");
            sv.Ten = Console.ReadLine();
            Console.WriteLine("Xin moi nhap tuoi SV:");
            sv.Tuoi = Console.ReadLine();
            // add sinh vien vào list
            listSV.Add(sv);
            Console.WriteLine("Thêm thành công");
        }

        public void LuuSV()
        {
            //ghi từng đứa vào trong file bằng foreach
            foreach(SinhVien s in listSV)
            {
                //Sử dụng FileService để gọi hàm ghi file
                FileService.GhiFile(s);
            }
        }


    }
}
