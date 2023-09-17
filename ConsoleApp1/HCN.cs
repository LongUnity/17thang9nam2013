using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class HCN
    {
        private float dai, rong;
        //có 3 loại Contructor
        //Contructor default
        public HCN()
        {

        }
        //Contructor có tham số
        public HCN(float dai, float rong)
        {
            this.dai = dai;
            this.rong = rong;
        }
        public HCN(HCN a)
        {
            this.dai = a.dai;
            this.rong=a.rong;
        }

        public void Nhap()
        {
            Console.WriteLine("Nhap chieu dai:");
            dai = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap chieu rong:");
            rong = float.Parse(Console.ReadLine());

        }
        public void Xuat()
        {
            Console.WriteLine("HCN co chieu dai " + dai + " chieu rong " + rong);
        }
        public float Chuvihcn()
        {
            return (dai + rong) * 2;
        }
        public float Dientichhcn() {
            return dai * rong;
        }
        //Tong 2 hcn(có thể nạp chồng (overload): nên để tên giống nhau)
        public float Chuvihcn(HCN a)
        {
            return this.Chuvihcn()+a.Chuvihcn();
        }
    }
}
