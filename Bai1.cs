using System;
using System.Text;

namespace Bai1
{
    class sinhVien
        {
            private String hoTen;
            private double dToan;
            private double dLy;
            private double dHoa;

            public sinhVien()
            {
                
            }
            public sinhVien(String hoTen, double dToan, double dLy, double dHoa)
            {
                this.hoTen = hoTen;
                this.dToan = dToan;
                this.dLy = dLy;
                this.dHoa = dHoa;
            }

            public double diemTrungBinh()
            {
                return (dToan + dLy + dHoa) / 3;
            }

            public String xepLoai()
            {
                double dtb = diemTrungBinh();
                if(dtb >= 5)
                    return "Dau";
                else
                    return "Rot";
            }

            public double diemMax()
            {
                return Math.Max(dToan, Math.Max(dLy, dHoa));
            }

            public String getHoTen()
            {
                return hoTen;
            }

            public double getDToan()
            {
                return dToan;
            }

            public double getDLy()
            {
                return dLy;
            }

            public double getDHoa()
            {
                return dHoa;
            }
        }
    class Bai1
    {
        static void nhapThongTin(sinhVien sv)
        {
            Console.Write("Nhap ho ten: ");
            String hoTen = Console.ReadLine();

            Console.Write("Nhap diem Toan: ");
            double dToan = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap diem Ly: ");
            double dLy = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap diem Hoa: ");
            double dHoa = Convert.ToDouble(Console.ReadLine());

        }

        static void hienThiThongTin(sinhVien sv)
        {
            Console.WriteLine("\n--- THÔNG TIN SINH VIÊN ---");
            Console.WriteLine("Họ tên: " + sv.getHoTen);
            Console.WriteLine("Toán: " + sv.getDToan);
            Console.WriteLine("Lý: " + sv.getDLy);
            Console.WriteLine("Hóa: " + sv.getDHoa);
            Console.WriteLine("Điểm trung bình: " + sv.diemTrungBinh());
            Console.WriteLine("Điểm cao nhất: " + sv.diemMax());
            Console.WriteLine("Kết quả: " + sv.xepLoai());
        }
        // static void Main(string[] args)
        // {
        //     Console.OutputEncoding = Encoding.UTF8;
        //     sinhVien sv = new sinhVien();

        //     nhapThongTin(sv);
        //     hienThiThongTin(sv);

        //     Console.ReadKey();
        // }
    }
}