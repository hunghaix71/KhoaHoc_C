using System;

namespace Buoi5_C
{
    class Buoi5
    {
        static void Main()
        {
            //BUỔI 5
            //Phan5_1();
            //Phan5_2();
            //Phan5_3();
            //BaiTapBuoi5_1();
            BaiTapBuoi5_2();
        }
        static void Phan5_1()
        {
            //5.1 Switch Case
            //switch (_BienKiemtra)
            //{
            // case _KetQua1: [Lệnh thực thi 1];
            // case _KetQUa2: [Lệnh thực thi 2];
            //}
            //Ví dụ: In ra thứ may
            Console.Write("Nhap so de kiem tra");
            string _BienKiemTra = Console.ReadLine();
            switch (_BienKiemTra)
            {
                case "1":
                    Console.Write("Hom nay la chu nhat");
                    break;
                case "2":
                    Console.Write("Hom nay la Thu hai");
                    break;
                case "3":
                    Console.Write("Hom nay la ba");
                    break;
                case "4":
                    Console.Write("Hom nay la tu");
                    break;
            }
            Console.ReadLine();
        }    
        static void Phan5_2()
        {
            //While
            //while ([Điều kiện đúng])
            //{
            // Lệnh thực nếu đúng
            //}
            //Ví dụ:
            int i = 0;
            while (i<=20)
            {
                
                if (i % 2 !=0)
                {
                    Console.Write("{0,-5} \n", i);
                }
                else
                {
                    Console.Write("{0,-5}", i);
                }
                i++;
            }
            Console.ReadLine();
        }
        static void Phan5_3()
        {
            //Do .... While
            //do
            //{
            //    //Cách lệnh đúng
            //}
            //while (Điều kiện để dừng);
            int i = 0;
            do
            {
                i++;
                if (i % 2 != 0)
                {
                    Console.Write("{0,-5} \n", i);
                }
                else
                {
                    Console.Write("{0,-5}", i);
                }
            }
            while (i <= 20);
            Console.ReadLine();
        }
        static void BaiTapBuoi5_1()
        {
            //Bài tập 1: Nhập họ tên cho đến lúc dừng
            string _KiemTra = "Y";//Khởi tạo biến kiểm tra bằng Y để bắt đầu
            int i = 1;//Khởi tạo biến đếm.
            while (_KiemTra == "Y")//Nếu _KiemTra = "Y" thì tiếp tục
            {
                Console.Write("({0}) Ho ten cua ban la gi? Minh ten la: ",i);
                string _HoTen = Console.ReadLine();
                Console.WriteLine("Xin chao " + _HoTen);
                Console.Write("Ban muon tiep tuc hay k (Y/N): ");

                _KiemTra = Console.ReadLine().ToUpper();             
                i++;
            }
            Console.WriteLine("Ban da dung");
            Console.ReadLine();
        }   
        static void BaiTapBuoi5_2()
        {
            //Bài tập 2:
            Console.Write("Nhap so muon chay den, N = ");
            string _str_N = Console.ReadLine();
            int _int_N = int.Parse(_str_N);
            int i = 0;
            while (i<=_int_N)//Điều kiện đúng
            {
                //Lệnh thực thi khi điều kiện đúng
                Console.Write("{0}\t", i);
                i +=2 ;
            }

            Console.ReadLine();
        } 
    }
}
