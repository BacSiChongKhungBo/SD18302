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
        SinhVien _sv;
        List<SinhVien> _listSV;

        public QuanLySinhVien() //khi khởi tạo class thì sẽ tạo 1 list sinh viên
        {
            _listSV = new List<SinhVien>();
        }

        //Nhập mới sinh viên
        public void NhapSV()
        {
            // khởi tạo sinh viên mỗi lần hàm NhapSV được chạy
            _sv = new SinhVien();
            Console.WriteLine("Xin moi nhap MaSV:");
            _sv.MaSV = Console.ReadLine();
            Console.WriteLine("Xin moi nhap ten SV:");
            _sv.Ten = Console.ReadLine();
            Console.WriteLine("Xin moi nhap tuoi SV:");
            _sv.Tuoi = Console.ReadLine();
            // add sinh vien vào list
            _listSV.Add(_sv);
            Console.WriteLine("Thêm thành công");
        }

        public void LuuSV()
        {
            FileService.SaveFile(_listSV);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Lưu dữ liệu thành công");
            Console.ResetColor();
        }

        public void LoadFile()
        {
            //Nếu file trả về null thì ko gán vào list
            List<SinhVien> temp = FileService.ReadFile();
            var data = temp;
            if (data.Count != 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Load dữ liệu thành công");
                Console.ResetColor();
                _listSV = data;          
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Không có dữ liệu");
                Console.ResetColor();
            }
        }

        public void XuatDS()
        {
            foreach(SinhVien s in _listSV)
            {
                s.InThongTin();
            }
        }


    }
}
