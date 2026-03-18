using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Tên: Nguyễn Tấn Chinh
// MSV: 2415053122301
// Lớp: 225LTC01
namespace Console_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<SinhVien> sv = new List<SinhVien>();
            Random rd = new Random();
            List<string> tenSV = new List<string>()
            {
                "Chinh", "Bình", "Hùng", "Hải", "Tùng", "Vũ", "Công", "Đức", "Thành", "Triều"
            };

            List<string> Khoa = new List<string>()
            {
                "Công nghệ số", "Điện - điện tử", "Môi trường", "Cơ khí"
            };

            for(int i = 0; i < 20; i++)
            {
                sv.Add(new SinhVien { ten = tenSV[rd.Next(tenSV.Count)], 
                                            tuoi =  rd.Next(18,25), khoa = Khoa[rd.Next(Khoa.Count)], 
                                            dtb = Math.Round(rd.NextDouble()*10,2), 
                                            namHoc = rd.Next(1,5) });
            }
            // Max tuoi
            int maxTuoi = sv.Max(s => s.tuoi);
            Console.WriteLine("Số tuổi max là: " + maxTuoi);
            // Min tuoi
            int minTuoi = sv.Min(s => s.tuoi);
            Console.WriteLine("Số tuổi min là: " + minTuoi);
            // Kiểm tra sinh viên có thuộc khoa CNS
            bool ktSv = sv.Any(s => s.khoa == "Công nghệ số");
            Console.WriteLine("Có sinh viên nào thuộc khoa Công nghệ số không: " + ktSv);
            // Lấy 10 sinh viên có điểm cao nhất khoa CNS
            var top10 = sv.Where(s => s.khoa == "Công nghệ số")
                          .OrderByDescending(s => s.dtb)
                          .Take(10);
            Console.WriteLine("\nTop 10 sinh viên có điểm cao nhất khoa Công nghệ số: ");
            foreach (var t in top10)
                Console.WriteLine($"Tên: {t.ten}, điểm trung bình: {t.dtb}");
            // Bỏ sinh viên năm cuối hiển thị ra danh sách các sinh vien còn lại
            var svConLai = sv.Where(s => s.namHoc < 4).ToList();
            Console.WriteLine("\nDanh sách sinh viên không phải sinh viên năm cuối: ");
            foreach (var s in svConLai)
                Console.WriteLine($"Tên: {s.ten} \t| Khoa: {s.khoa} \t| Năm học: {s.namHoc} \t| ĐTB: {s.dtb}");

            Console.ReadKey();
        }
    }
}
