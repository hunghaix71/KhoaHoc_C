using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_ChuaBai
{
   public class NguyenTuanAnh_0385081264
    {
        //Khởi tạo List toàn cục, thuộc kiểu danh sách các mảng 1 chiều:
        static List<string[]> _DanhSach_HocSinh = new List<string[]>();
        public void BaiKiemTra()
        {
            //Khởi tạo tên cột
            string[] _TenCot = new string[] { "STT", "Ho va Ten", "Toan", "Ly", "Hoa", "ĐTB", "Xep Loai" };
            //Thêm mảng tên cột vào danh sách
            _DanhSach_HocSinh.Add(_TenCot);
            //Bat đầu nhập liệu
            string _KiemTra = "Y";//Khởi tạo biến kiểm tra bằng Y để bắt đầu
            int _stt = 1;//Khởi tạo biến đếm.
            while (_KiemTra == "Y")//Nếu _KiemTra = "Y" thì tiếp tục
            {
                //Nhập các thông tin: 
                string _Hoten = Nhapten();
                double _dou_Toan = NhapDiem("Toan");
                double _dou_Ly = NhapDiem("Ly");
                double _dou_Hoa = NhapDiem("Hoa");
                //Tính điểm trung bình:
                double _dou_DTB = (_dou_Toan + _dou_Ly + _dou_Hoa) / 3;
                //Làm tròn số thập phân
                _dou_DTB = Math.Round(_dou_DTB, 2);
                //Xếp loại học lực
                string _XepLoai = DanhGiaHocLuc(_dou_DTB);
                //Tạo 1 dòng (Mảng 1 chiều)
                string[] _dong = new string[] { Convert.ToString(_stt),//STT
                                                _Hoten,//Họ và tên
                                                Convert.ToString(_dou_Toan),//Điểm toán
                                                Convert.ToString(_dou_Ly),//Điểm lý
                                                Convert.ToString(_dou_Hoa),//Điểm Hóa
                                                Convert.ToString(_dou_DTB),//Điểm trung bình
                                                _XepLoai};

                _DanhSach_HocSinh.Add(_dong);
                //HỎi lại xem có tiếp tục không
                Console.WriteLine("___________________________________");
                Console.Write("Ban muon tiep tuc hay khong (Y/N): ");
                _KiemTra = Console.ReadLine().ToUpper();
                _stt++;
            }
            //Bắt đầu in danh sách:
            Console.WriteLine("===================DANH SACH HOC SINH=======================");
            for (int i = 0; i < _DanhSach_HocSinh.Count; i++)
            {
                string[] _Dong = _DanhSach_HocSinh[i];
                //In Kết quả
                Console.Write("{0,-5}|", _DanhSach_HocSinh[i][0]);//STT
                Console.Write("{0,-20}|", _Dong[1]);//Họ và tên
                Console.Write("{0,-5}|", _Dong[2]);//Điểm toán
                Console.Write("{0,-5}|", _Dong[3]);//Điểm lý
                Console.Write("{0,-5}|", _Dong[4]);//Điểm Hóa
                Console.Write("{0,-5}|", _Dong[5]);//Điểm trung bình
                Console.WriteLine("{0,-10}", _Dong[6]);//Xếp loại
            }
            //Sắp xếp giảm dần
            List<string[]> _DanhSachMoi_GiamDan = SapXep_GiamDan(_DanhSach_HocSinh);
            //Bắt đầu in danh sách:
            Console.WriteLine("");
            Console.WriteLine("===================SAP XEP GIAM DAN=======================");
            for (int i = 0; i < _DanhSachMoi_GiamDan.Count; i++)
            {
                string[] _Dong = _DanhSachMoi_GiamDan[i];
                //In Kết quả
                Console.Write("{0,-5}|", _Dong[0]);//STT
                Console.Write("{0,-20}|", _Dong[1]);//Họ và tên
                Console.Write("{0,-5}|", _Dong[2]);//Điểm toán
                Console.Write("{0,-5}|", _Dong[3]);//Điểm lý
                Console.Write("{0,-5}|", _Dong[4]);//Điểm Hóa
                Console.Write("{0,-5}|", _Dong[5]);//Điểm trung bình
                Console.WriteLine("{0,-10}", _Dong[6]);//Xếp loại
            }
            //Sắp xếp tang dần
            List<string[]> _DanhSachMoi_TangDan = SapXep_TangDan(_DanhSach_HocSinh);
            //Bắt đầu in danh sách:
            Console.WriteLine("");
            Console.WriteLine("===================SAP XEP TANG DAN=======================");
            for (int i = 0; i < _DanhSachMoi_TangDan.Count; i++)
            {
                string[] _Dong = _DanhSachMoi_TangDan[i];
                //In Kết quả
                Console.Write("{0,-5}|", _Dong[0]);//STT
                Console.Write("{0,-20}|", _Dong[1]);//Họ và tên
                Console.Write("{0,-5}|", _Dong[2]);//Điểm toán
                Console.Write("{0,-5}|", _Dong[3]);//Điểm lý
                Console.Write("{0,-5}|", _Dong[4]);//Điểm Hóa
                Console.Write("{0,-5}|", _Dong[5]);//Điểm trung bình
                Console.WriteLine("{0,-10}", _Dong[6]);//Xếp loại
            }
            Console.ReadLine();
        }
        static List<string[]> SapXep_GiamDan(List<string[]> _DanhSach)
        {
            for (int i = 1; i < _DanhSach.Count - 1; i++)
            {
                for (int j = i + 1; j < _DanhSach.Count; j++)
                {
                    if (Convert.ToDouble(_DanhSach[i][5]) < Convert.ToDouble(_DanhSach[j][5]))
                    {
                        string[] _Dong_TG = _DanhSach[i];
                        _DanhSach[i] = _DanhSach[j];
                        _DanhSach[j] = _Dong_TG;
                    }
                }
            }
            //Đánh lại stt
            for (int i = 1; i < _DanhSach.Count; i++)
            {
                _DanhSach[i][0] = Convert.ToString(i);
            }
            return _DanhSach;
        }
        static List<string[]> SapXep_TangDan(List<string[]> _DanhSach)
        {
            for (int i = 1; i < _DanhSach.Count - 1; i++)
            {
                for (int j = i + 1; j < _DanhSach.Count; j++)
                {
                    if (Convert.ToDouble(_DanhSach[i][5]) > Convert.ToDouble(_DanhSach[j][5]))
                    {
                        string[] _Dong_TG = _DanhSach[i];
                        _DanhSach[i] = _DanhSach[j];
                        _DanhSach[j] = _Dong_TG;
                    }
                }
            }
            //Đánh lại stt
            for (int i = 1; i < _DanhSach.Count; i++)
            {
                _DanhSach[i][0] = Convert.ToString(i);
            }
            return _DanhSach;
        }
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
                        return Nhapten();
                    }
                }
                else
                {
                    Console.WriteLine("Khong duoc nhap so vao ho ten!");
                    return Nhapten();
                }
            }
            else
            {
                Console.WriteLine("Ban chua nhap ho ten cua ban!");
                return Nhapten();
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
    }
}


