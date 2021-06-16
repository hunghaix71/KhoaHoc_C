using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi7_C
{
    class BuiQuangHung_0853400493
    {
        public void Test_Class()
        {
            string _KiemTra = "C";//Khởi tạo biến kiểm tra bằng Y để bắt đầu

            int i = 1;//Khởi tạo biến đếm.
            while (_KiemTra == "C")//Nếu _KiemTra = "Y" thì tiếp tục
            {
                Console.Write("Nhap ho ten: ", i);
                string _HoTen = Console.ReadLine();
                Console.WriteLine("Day la hs " + _HoTen);
                double _DiemToan = NhapDiem("toán");
            double _DiemLy = NhapDiem("lý");
            double _DiemHoa = NhapDiem("hóa");
            double _DTB = Math.Round((_DiemHoa + _DiemToan + _DiemLy) / 3,2);
            string _HocLuc = DanhGiaHocLuc(_DTB);
                Console.Write("Ban muon tiep tuc hay k (C/K): ");
                _KiemTra = Console.ReadLine().ToUpper();
                Console.Write("{0,-5}|", "Hoa");
                Console.Write("{0,-5}|", "Toan");
                Console.Write("{0,-5}|", "Ly");
                Console.Write("{0,-5}|", "DTB");
                Console.WriteLine("{0,-10}", "Hoc luc");
                //In Kết quả
               
                Console.Write("{0,-5}|", _DiemHoa);
                Console.Write("{0,-5}|", _DiemToan);
                Console.Write("{0,-5}|", _DiemLy);
                Console.Write("{0,-5}|", _DTB);
                Console.Write("{0,-10}", _HocLuc);
                static string Nhapten()
                {
                    Console.Write("Ho ten cua ban la: ");
                    string _HoTen = Console.ReadLine();
                    if (_HoTen != "" && _HoTen != " ")  //Cách 1: Kiểm tra rỗng
                    {
                        if (!char.IsNumber(_HoTen, 0)) //Kiểm tra nó là số hay không
                        {
                            if (_HoTen.Length > 3) //Kiểm tra nhập quá ngắn
                            {
                                return _HoTen;
                            }
                            else
                            {
                                Console.WriteLine("Ho ten cua ban qua ngan!");
                                Nhapten();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Khong duoc nhap so vao ho ten!");
                            Nhapten();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ban chua nhap ho ten cua ban!");
                        Nhapten();
                    }
                    //if (string.IsNullOrEmpty(_HoTen) && string.IsNullOrWhiteSpace(_HoTen)) //Cách 2: Kiểm tra rỗng
                    //{

                    //}
                    return "";

                }
                static double NhapDiem(string _TenMonHoc)
                {
                    double _dbl_Diem = 0.0;
                    Console.Write("diem mon {0} cua ban la: ", _TenMonHoc);
                    string _str_Diem = Console.ReadLine();
                    if (_str_Diem != "" && _str_Diem != " ")//DK1: Kiểm tra rỗng
                    {
                        if (char.IsNumber(_str_Diem, 0))//DK2: Kiem tra la so hay không
                        {
                            _dbl_Diem = double.Parse(_str_Diem);
                            if (_dbl_Diem >= 0) //DK3: Kiểm tra nhâp số âm
                            {
                                if (_dbl_Diem <= 10) //DK4: Nhap diem qua to
                                {
                                    return _dbl_Diem;
                                }
                                else
                                {
                                    Console.WriteLine("Diem khong hop ly!");
                                    return NhapDiem(_TenMonHoc);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ban phai nhap so duong!");
                                return NhapDiem(_TenMonHoc);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ban phai nhap so!");
                            return NhapDiem(_TenMonHoc);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ban chua nhap diem!");
                        return NhapDiem(_TenMonHoc);
                    }
                    //return _dbl_Diem;
                }
                static string DanhGiaHocLuc(double _DTB)
                {
                    string _HocLuc = "";
                    if (_DTB >= 0 && _DTB < 5)
                    {
                        _HocLuc = "Trung binh";
                    }
                    else if (_DTB >= 5 && _DTB < 7)
                    {
                        _HocLuc = "Kha";

                    }
                    else if (_DTB >= 7 && _DTB <= 10)
                    {
                        _HocLuc = "Gioi";
                    }
                    return _HocLuc;
                }
                i++;
               
            }
            Console.WriteLine("Dung");
            Console.ReadLine();
           
        }
    }
}
