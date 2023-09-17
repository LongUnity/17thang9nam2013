using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace C__Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Đối tượng trong thế giới thực là 1 thực thể cụ thể: Người, Vật,...
            //Mỗi đối tượng gồm 2 thành phần: thuộc tính và phương thức
            //Class(lớp): là các Object(đối tượng) có các thuộc tính tương tự nhau, được gom chung thành Class(lớp đối tượng).
            //Và mỗi lớp có đặc trưng về thuộc tính và hành động.
            //Có 4 đặc điểm quan trọng của OOP:
            //+Trừu Tượng: Là cách nhìn khái quát hóa về 1 tập các đối tượng có chung các đặc điểm được quan tâm và bỏ qua những chi
            //tiết không cần thiết
            //+Đóng Gói:
            //+Đa Hình:
            //+Kế Thừa:
            Console.OutputEncoding = Encoding.UTF8;
            
            DanhSachDate dsd= new DanhSachDate();
            dsd.nhap();
            Console.WriteLine("ngay truoc khi sap xep:");
            dsd.xuat();

            //dsd.sapXepdatetangdan();
            dsd.sapXepdategiamdan();
            Console.WriteLine("ngay sau khi sap xep:");
            dsd.xuat();
            

            Console.ReadKey();
            
        }
    }
}