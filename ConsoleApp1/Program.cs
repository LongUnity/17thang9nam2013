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
        /*static void Nhapchuoikitu(out string n)
        {
            Console.Write("Nhập Chuỗi kí tự: ");
            n = Console.ReadLine();
        }*/

        //Bài 1: Nhập họ tên của 1 người, xóa tên đệm của người đó
        /*static string Xoatendem(string fullName)
        {
            // tách tên lấy họ và tên.
            string[] ten = fullName.Split(' ');
            string firstName = ten[0];//họ
            string lastName = ten[ten.Length - 1];//tên

            // chỉ in ra họ và tên không có tên đệm.
            fullName = firstName + " " + lastName;

            return fullName;
        }*/
        //Bài 2:  chuẩn hóa địa chỉ IP sao cho mỗi thành phần đủ 3 kí tự số: vd IP="1.2.12.3" => "001.002.012.003"
        /*static string Chuanhoaip(string ip)
        {
            // tách các số ip
            string[] temp = ip.Split('.');

            // lặp qua từng số và thêm 0
            for (int i = 0; i < temp.Length; i++)
            {
                while (temp[i].Length < 3)
                {
                    temp[i] = "0" + temp[i];
                }
            }

            // thêm lại dấu "."
            ip = string.Join(".", temp);

            return ip;
        }
        */
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
            //Bài 3:
            /*Tamgiac abc = new Tamgiac();
            abc.nhap();
            abc.xuat();
            Console.WriteLine(abc.chuVi());
            Console.WriteLine(abc.dienTich());
            Console.WriteLine("Co phai la tam giac vuong khong? "+abc.checkTamgiacvuong());*/

            SinhVien a = new SinhVien("Nguyen van a",19,5,4);
            a.Xuat();
            a.ketQua();



            Console.ReadKey();
            
        }
    }
}