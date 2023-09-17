using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Nguoi
    {
        //property
        string ten;
        int tuoi;
        int chieucao;

        //method
        public void Nhaptt()
        {
            Console.WriteLine("Nhap ten:");
            ten = Console.ReadLine();
            Console.WriteLine("Nhap chieucao:");
            chieucao = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap tuoi:");
            tuoi = int.Parse(Console.ReadLine());

        }
        public void Xuattt()
        {
            Console.WriteLine("ten: "+ten+" chieu cao: "+chieucao+" tuoi: "+tuoi);
        }

    }
}
