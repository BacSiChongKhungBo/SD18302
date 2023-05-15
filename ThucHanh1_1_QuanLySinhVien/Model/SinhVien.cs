using System;
using System.Collections.Generic;
using System.Text;

namespace ThucHanh1_1_QuanLySinhVien.Model
{
    [Serializable] //có thể mã hóa đối tượng
    class SinhVien
    {
        //Sinh vien có Mã SV, Tên, tuổi
        private string maSV; //get set thay cho Encapsalute field
        private string ten;
        private string tuoi;

        public SinhVien()
        {

        }

        public SinhVien(string maSV, string ten, string tuoi)
        {
            this.maSV = maSV;
            this.ten = ten;
            this.tuoi = tuoi;
        }

        public string MaSV { get => maSV; set => maSV = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Tuoi { get => tuoi; set => tuoi = value; }

        public void InThongTin()
        {
            Console.WriteLine(maSV + " | " + ten + " | " + tuoi);
        }
    }
}
