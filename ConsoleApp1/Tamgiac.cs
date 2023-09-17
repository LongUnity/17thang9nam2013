using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Tamgiac
    {
        private Diemtoado A, B, C;

        public void nhap()
        {
            Console.WriteLine("Nhap toa do dinh A:");
            this.A = new Diemtoado();
            A.nhap();
            Console.WriteLine("Nhap toa do dinh B:");
            this.B = new Diemtoado();
            B.nhap();
            Console.WriteLine("Nhap toa do dinh C:");
            this.C = new Diemtoado();
            C.nhap();

        }
        public void xuat()
        {
            Console.WriteLine("Toa do dinh A,B,C:");
            A.xuat();
            B.xuat();
            C.xuat();
        }

        
        
        public double chuVi() 
        {
            double AB = this.A.khoangCach(this.B);
            double BC = this.B.khoangCach(this.C);
            double CA = this.C.khoangCach(this.A);

            return AB + BC + CA;
        }
        public double dienTich()
        {
            double p = this.chuVi()/2;
            double AB = this.A.khoangCach(this.B);
            double BC = this.B.khoangCach(this.C);
            double CA = this.C.khoangCach(this.A);

            return Math.Sqrt(p * (p - AB) * (p - BC) * (p - CA));
        }

        public Boolean checkTamgiacvuong()
        {
            double AB = this.A.khoangCach(this.B);
            double BC = this.B.khoangCach(this.C);
            double CA = this.C.khoangCach(this.A);

            if(AB*AB==BC*BC + CA * CA)
            {
                Console.WriteLine("Vuông tại đỉnh C");
                return true;
            }
            else if (BC * BC==AB * AB + CA * CA)
            {
                Console.WriteLine("Vuông tại đỉnh A");
                return true;
            }
            else if (CA * CA == BC * BC + AB * AB)
            {
                Console.WriteLine("Vuông tại đỉnh B");
                return true;
            }
            return false;
        }


    }
}
