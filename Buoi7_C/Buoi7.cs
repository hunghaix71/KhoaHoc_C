using System;
using System.Collections.Generic;

namespace Buoi7_C
{
    class Buoi7
    {
        //Tạo danh sách mảng
        static List<string[]> _lst_mang_str = new List<string[]>();
        static void Main()
        {
            HoVaTen_SDT _TenClass = new HoVaTen_SDT();
            _TenClass.Test_class();
            //_ViDu_2();
        }
        static void _ViDu_1()
        {
            //Danh sách đa chiều List
            List<string> _lst_str = new List<string>();//Khai báo danh sách
            //Khởi tạo các phần tử;
            string _b1 = "b";//0
            string _b2 = "a";//1
            string _b3 = "c";//2
            //Thêm các phần tử đó vào danh sách
            _lst_str.Add(_b1);
            _lst_str.Add(_b2);
            _lst_str.Add(_b3);
            
            //Thêm 1 mảng vào trong danh sách
            string[] _mang_str = { _b3, _b2, _b1 };
            _lst_str.AddRange(_mang_str);

            //sắp xếp theo alphab
            _lst_str.Sort();

            //in ra màn hình
            /* foreach(string _item_str in _lst_str)
             {
                 Console.WriteLine(_item_str);
             }
             Console.ReadLine();*/
            for (int i = 0; i < _lst_str.Count; i++)
            {
                Console.WriteLine(_lst_str[i]);
            }
            Console.ReadLine();
        }
        static void _ViDu_2()
        {

            //Tạo dòng 1: tên cột
            string[] _Mang_str_TenCot = { "Ho và ten", "Dien tich","Don vi"};
            _lst_mang_str.Add(_Mang_str_TenCot);
            //tạo dòng thứ 2: Dữ liệu
            string[] _Mang_str_1 = { "Hv1", "35.6","(cm2)"};
            _lst_mang_str.Add(_Mang_str_1);
            //tạo dòng thứ 3: Dữ liệu
            string[] _Mang_str_2 = { "Hv2", "24.4", "(cm2)" };
            _lst_mang_str.Add(_Mang_str_2);
            //In ra màn hình
            foreach (string[] _item_str in _lst_mang_str)
            {
                Console.Write("{0,-10}",_item_str[0]);
                Console.Write("{0,-15}", _item_str[1]);
                Console.Write("{0,-10}\n", _item_str[2]);
            }
            Console.ReadLine();

        }
    }
}
