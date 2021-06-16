using System;
using System.Collections.Generic;

namespace Buoi7_C
{
    class Program
    {
        static void Main()
        {
             BuiQuangHung_0853400493 _TenClass = new BuiQuangHung_0853400493();
            _TenClass.Test_Class();
            Console.ReadKey();
        //_Vidu_2();
        }
        /*static void _Vidu_1()
        {
            // Danh sách da chiều array
            List<string> _lst_str = new List<string>();//Khai báo danh sách
            //Khởi tạo các phần tử 
            Array _arr_int;
            string _b1 = "a";//0
            string _b2 = "b";//1
            string _b3 = "c";//2
            //Thêm các phần tử đó vào danh sách 
            _lst_str.Add(_b1);
            _lst_str.Add(_b2);
            _lst_str.Add(_b3);
            //in ra màn hình 
            *//*  foreach(string _item_str in _lst_str)
              {
                  Console.WriteLine(_item_str);
              }
              Console.ReadLine();*//*
            string[] _mang_str = { _b3, _b2, _b1 };//Thêm 1 mảng vào trong danh sách
            _lst_str.AddRange(_mang_str);
            _lst_str.Sort();// Sắp xếp theo Alpha 
            for (int i=1;i<_lst_str.Count;i++)
            {
                Console.WriteLine(_lst_str[i]);
            }
            Console.ReadLine();
        }
        static void _Vidu_2()
        {
            // Tạo danh sách mảng
            List<string[]> _lst_mang_int = new List<string[]>();
            string[] _Mang_str_TenCot = { "Ten", "Dien tich", "Don Vi" };
            _lst_mang_int.Add(_Mang_str_TenCot);
            string[] _Mang_str_1 = { "Hv1", "35.6", "(cm2)" };
            _lst_mang_int.Add(_Mang_str_1);
            foreach (string[] _item_str in _lst_mang_str)
            {
                Console.Write("{0,-10}", _item_str[0]);
                Console.Write("{0,-15}", _item_str[0]);
                Console.Write("{0,-10}", _item_str[0]);

            }

        }*/
    }
}
