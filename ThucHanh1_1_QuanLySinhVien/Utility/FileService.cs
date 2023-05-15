using ThucHanh1_1_QuanLySinhVien.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;

namespace ThucHanh1_1_QuanLySinhVien.Utility
{
    class FileService
    {
        //khai báo đường dẫn file
        private static string _fpath = @"E:\SD18302-main\ThucHanh1_1_QuanLySinhVien\Data\SinhVien.bin";
        // khai báo luồng file
        private static FileStream _fs;
        // khai báo Mã hóa
        private static BinaryFormatter _bf;

        //ctor + tab
        public FileService()
        {

        }

        public static void SaveFile(List<SinhVien> listSV)
        {
            //khởi tạo luồng file
            _fs = new FileStream(_fpath, FileMode.Create);
            // khởi tạo quy trình mã hóa file
            _bf = new BinaryFormatter();
            //mã hóa dữ liệu vào file
            _bf.Serialize(_fs, listSV);
            //đóng luồng file
            _fs.Close();
        }

        public static List<SinhVien> ReadFile()
        {
            if (File.Exists(_fpath))
            {
                //khởi tạo luồng file
                _fs = new FileStream(_fpath, FileMode.Open);
                // khởi tạo quy trình mã hóa file
                _bf = new BinaryFormatter();
                //Giải mã file và dữ liệu
                var data = _bf.Deserialize(_fs);
                //đóng luồng file
                _fs.Close();
                //Trả về data được ép kiểu
                return (List<SinhVien>)data;
            }
            else
            {
                List<SinhVien> data = new List<SinhVien>();
                return data;
            }
            
        }
    }
}
