using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class PhanSo
    {
        private int tuso, mauso;

        public PhanSo()
        {

        }
        public PhanSo(int tuso, int mauso)
        {
            this.tuso = tuso;
            this.mauso = mauso;
        }

        /*public void Nhapps()
        {
            Console.WriteLine("Nhập tử số:");
            tuso = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập mẫu số:");
            mauso = int.Parse(Console.ReadLine());

            if(mauso == 0)
            {
                Console.WriteLine("Nhap lai mau so. Mau so khong the la so 0!!!");
                mauso = int.Parse(Console.ReadLine());
            }
        }*/
        public void Xuatps()
        {
            if (this.tuso % this.mauso==0)
            {
                Console.WriteLine(this.tuso/ this.mauso);
            }
            else
            {
                Console.WriteLine(tuso + "/" + mauso);
            }
        }

        public int UCLN(int a,int b) {
            int min = a;
            if (a > b)
            {
                min = b;
            }
            for(int i = min; a > i; i--)
            {
                if(a%i==0 && b%i== 0)
                {
                    return i;
                }
            }
            return 1;
        }

        public void rutGon()
        {
            int ucln = UCLN(this.tuso,this.mauso);
            this.tuso /= ucln;
            this.mauso /= ucln;
        }
        public PhanSo tong2ps(PhanSo a)
        {
            PhanSo phanso = new PhanSo();
            phanso.tuso = this.tuso*a.mauso+a.tuso*this.mauso;
            phanso.mauso = this.mauso * a.mauso;
            phanso.rutGon();
            return phanso;
        }
        public PhanSo hieu2ps(PhanSo a)
        {
            PhanSo phanso = new PhanSo();
            phanso.tuso = this.tuso * a.mauso - a.tuso * this.mauso;
            phanso.mauso = this.mauso * a.mauso;
            phanso.rutGon();
            return phanso;
        }
        public PhanSo tich2ps(PhanSo a)
        {
            PhanSo phanso = new PhanSo();
            phanso.tuso = this.tuso * a.tuso;
            phanso.mauso = this.mauso * a.mauso;
            phanso.rutGon();
            return phanso;
        }
        public PhanSo thuong2ps(PhanSo a)
        {
            PhanSo phanso = new PhanSo();
            phanso.tuso = this.tuso * a.mauso;
            phanso.mauso = this.mauso * a.tuso;
            phanso.rutGon();
            return phanso;
        }

    }
}
