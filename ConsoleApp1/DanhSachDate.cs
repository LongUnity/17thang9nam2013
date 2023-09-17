using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DanhSachDate
    {
        private int n;
        private Date[] arr;
        public DanhSachDate() { }
        
        public void nhap()
        {
            Console.WriteLine("Số lượng ngày cần nhập: ");
            this.n = int.Parse(Console.ReadLine());
            arr = new Date[this.n];
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap ngay "+(i+1)+":");
                arr[i] = new Date();
                arr[i].nhap();
            }
        }
        public void xuat()
        {
                        
            for (int i = 0; i < n; i++)
            {
                arr[i].xuat();
            }
        }
        public void sapXepdatetangdan()
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (this.arr[i].soSanhDate(this.arr[j])==1)
                    {
                        Date temp = this.arr[i];
                        this.arr[i] = this.arr[j];
                        this.arr[j] = temp;
                    }
                }
            }

        }
        public void sapXepdategiamdan()
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (this.arr[i].soSanhDate(this.arr[j]) == -1)
                    {
                        Date temp = this.arr[i];
                        this.arr[i] = this.arr[j];
                        this.arr[j] = temp;
                    }
                }
            }

        }
    }
}
