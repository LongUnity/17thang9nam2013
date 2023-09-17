using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SinhVien
    {
        private string hoTen;
        private int tuoi;
        float diemLT,diemTH;
        
        public SinhVien() { 
        
        }
        public SinhVien(string hoTen,int tuoi,float diemLT,float diemTH)
        {
            this.hoTen = hoTen;
            this.tuoi = tuoi;
            this.diemLT = diemLT;
            this.diemTH = diemTH;
        }

        public void Xuat()
        {
            Console.WriteLine("ho va ten: "+hoTen);            
            Console.WriteLine("tuoi: "+tuoi);
            Console.WriteLine("diem ly thuyet: "+diemLT);
            Console.WriteLine("diem thuc hanh: "+diemTH);
        }

        

        public Boolean ketQua()
        {
            float dtb = (diemLT + diemTH) / 2;
            Console.WriteLine("Điểm trung bình của sinh viên " + hoTen + " là: " + dtb);
            if (dtb < 5)
            {
                Console.WriteLine("Sinh viên " + hoTen + " đã rớt");
                return false;
            }
            else 
            {
                Console.WriteLine("Sinh viên " + hoTen + " đã đậu");
                return true;
            }
            
        }
    }
}
