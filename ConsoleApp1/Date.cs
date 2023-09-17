using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Date
    {
        private int ngay, thang, nam;

        public Date() { }
        /*public Date(int ngay, int thang, int nam)
        {
            this.ngay = ngay;
            this.thang = thang;
            this.nam = nam;
        }*/
        public void nhap()
        {
            this.ngay = int.Parse(Console.ReadLine());
            Console.Write(" / ");
            this.thang = int.Parse(Console.ReadLine()); 
            Console.Write(" / ");
            this.nam = int.Parse(Console.ReadLine());
        }
        public void xuat()
        {
            Console.WriteLine($"Ngày {ngay}, tháng {thang}, năm {nam}");
        }
        public int checkDay() 
        { 
            if ( this.thang == 2 ) 
            {
                if (this.nam % 4 == 0)
                {
                    if (this.nam % 100 == 0)
                    {
                        if (this.nam % 400 == 0)
                        {
                            return 29;
                        }
                        else return 28;
                    }
                    else return 29;                    
                }
                else
                {
                    return 28;
                }
            }
            else if (this.thang == 4 || this.thang == 6|| this.thang ==9||this.thang== 11) 
            {
                return 30;
            }
            else { return 31;}

        }

        //ngay tiếp theo
        public Date nextDay() 
        {
            Date kq = new Date();

            if (this.ngay != this.checkDay())
            {
                Console.WriteLine($"Ngày {kq.ngay=this.ngay+1}, tháng {kq.thang=this.thang}, năm {kq.nam = this.nam}");
            }
            else
            {
                if (this.thang == 12)
                {
                    Console.WriteLine($"Ngày {1}, tháng {1}, năm {kq.nam=this.nam+1}");
                }
                else
                {
                    Console.WriteLine($"Ngày {1}, tháng {kq.thang=this.thang+1}, năm {kq.nam = this.nam + 1}");
                }
            }
            

            return kq;
        }
        //ngày hôm qua
        public Date dayBefore()
        {
            Date kq = new Date();
            if (this.ngay != 1)
            {
                Console.WriteLine($"Ngày {kq.ngay = this.ngay -1}, tháng {kq.thang = this.thang}, năm {kq.nam = this.nam}");
            }
            else
            {
                if (this.thang == 1)
                {
                    Console.WriteLine($"Ngày {31}, tháng {12}, năm {kq.nam = this.nam - 1}");
                }
                else
                {                    
                    kq.thang = this.thang - 1;
                    kq.ngay = kq.checkDay();
                    Console.WriteLine($"Ngày {kq.ngay}, tháng {kq.thang}, năm {kq.nam = this.nam}");                    
                }
            }


            return kq;
        }
        public int soSanhDate(Date b)
        {
            if (this.nam > b.nam)
            {
                return 1;
            }
            else if (this.nam < b.nam)
            {
                return -1;
            }
            else 
            {
                if (this.thang > b.thang)
                {
                    return 1;
                }
                else if (this.thang < b.thang)
                {
                    return -1;
                }
                else
                {
                    if (this.ngay > b.ngay)
                    {
                        return 1;
                    }
                    else if (this.ngay < b.ngay)
                    {
                        return -1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

    }
    
}
