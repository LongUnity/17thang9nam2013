using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Diemtoado
    {
        private float x, y;

        public Diemtoado() { }

        public void nhap()
        {
            Console.WriteLine("Nhap hoanh do:");
            this.x = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap tung do:");
            this.y = float.Parse(Console.ReadLine());

        }
        public void xuat()
        {
            Console.WriteLine($"({this.x},{this.y})");
        }



        public double khoangCach(Diemtoado B) 
        { 
            return Math.Sqrt(((this.x - B.x)* (this.x - B.x))+((this.y - B.y)* (this.y - B.y)));
        }
    }
}
