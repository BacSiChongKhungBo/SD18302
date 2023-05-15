using System;
using System.IO;
using System.Text;

namespace Bai1_1_LamQuenVoiFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Để làm việc với file
            // quan trọng số 1 đó là địa chỉ và tên file
            // fpath = file path : đường dẫn file, địa chỉ file,...
            string fpath = @"D:\SinhVien.txt"; //@ để có thể SD dấu \


            // Xóa file nếu địa chỉ đó đã có file tồn tại
            if (File.Exists(fpath)) //import System.IO để sử dụng File
            {
                File.Delete(fpath);
            }

            //tạo file mới và đưa dữ liệu vào file
            // sử dụng using
            // FileStream trong system.IO
            using (FileStream fs = File.Create(fpath))
            {
                AddTexttoFile(fs, "Xin Chao");
                AddTexttoFile(fs, "\n\r");
            }
        }

        //Đưa dữ liệu vào trong file
        private static void AddTexttoFile(FileStream fs, string content)
        {
            //cung cấp thông tin cho chương trình
            byte[] info = new UTF8Encoding(true).GetBytes(content);
            // Sau khi cung cấp thông tin dữ liệu cho chương trình
            // tiến hành xử lý dữ liệu
            // Cụ thể là ghi file
            fs.Write(info, 0, info.Length);

        }
    }
}
