using ThucHanh1_1_QuanLySinhVien.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ThucHanh1_1_QuanLySinhVien.Utility
{
    class FileService
    {
        public static void GhiFile(SinhVien sv)
        {
            //Để làm việc với file
            // quan trọng số 1 đó là địa chỉ và tên file
            // fpath = file path : đường dẫn file, địa chỉ file,...
            string fpath = @"D:\SinhVien.txt"; //@ để có thể SD dấu \


            // Xóa file nếu địa chỉ đó đã có file tồn tại
            if (File.Exists(fpath)) //import System.IO để sử dụng File
            {
                //File.Delete(fpath);
                // Vì file tồn tại rồi nên ko cần create nữa
                using (FileStream fs = File.Open(fpath, FileMode.Append))
                {
                    AddTexttoFile(fs, sv.InThongTin());
                }
            }
            else //nếu chưa có file thì tạo và addtext vào
            {
                using (FileStream fs = File.Create(fpath))
                {
                    AddTexttoFile(fs, sv.InThongTin());
                }
            }

            //tạo file mới và đưa dữ liệu vào file
            // sử dụng using
            // FileStream trong system.IO
            
        }

        //Đưa dữ liệu vào trong file
        private static void AddTexttoFile(FileStream fs, string content)
        {
            content = content + "\n";
            //cung cấp thông tin cho chương trình
            byte[] info = new UTF8Encoding(true).GetBytes(content);
            // Sau khi cung cấp thông tin dữ liệu cho chương trình
            // tiến hành xử lý dữ liệu
            // Cụ thể là ghi file
            fs.Write(info, 0, info.Length);

        }

    }
}
