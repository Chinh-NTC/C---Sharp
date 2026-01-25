using System;
using System.Text;

namespace lt
{
    class Program
    {
        static void nhap(String[] ten, double[] toan, double[] ly, double[] hoa, int n)
        {
            int i;
            for(i=0; i<n; i++)
            {
                Console.Write("Nhap ho va ten sinh vien thu {0}: ", i+1);
                ten[i] = Console.ReadLine();
                Console.Write("Nhap diem toan: ");
                toan[i] = double.Parse(Console.ReadLine());
                Console.Write("Nhap diem ly: ");
                ly[i] = double.Parse(Console.ReadLine());
                Console.Write("Nhap diem hoa: ");
                hoa[i] = double.Parse(Console.ReadLine());
            }
        }

        static double diemTrungBinh(double toan, double ly, double hoa)
        {
            return (toan + ly + hoa) / 3;
        }
        
        static double diemMax(double toan, double ly, double hoa)
        {
            return Math.Max(toan, Math.Max(ly, hoa));
        }    
        
        static String xepLoai(double dtb)
        {
            if(dtb >= 5)
                return "Dau";
            else
                return "Rot";
        }

        static void hienThiThongTin(String[] ten, double[] toan, double[] ly, double[] hoa, int n)
        {
            int i;
            Console.WriteLine("Danh sach sinh vien:");
            for(i=0; i<n; i++)
            {
                double dtb = diemTrungBinh(toan[i], ly[i], hoa[i]);
                double dmax = diemMax(toan[i], ly[i], hoa[i]);
                String loai = xepLoai(dtb);
                Console.WriteLine("Sinh vien: {0}, Diem TB: {1:F2}, Diem Max: {2}, Xep loai: {3}", ten[i], dtb, dmax, loai);
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            Console.Write("Nhap so luong sinh vien: ");
            n = int.Parse(Console.ReadLine());
            String[] ten = new String[n];
            double[] toan = new double[n];
            double[] ly = new double[n];
            double[] hoa = new double[n];
            nhap(ten, toan, ly, hoa, n);
            hienThiThongTin(ten, toan, ly, hoa, n);

            Console.ReadKey();
        }
    }
}