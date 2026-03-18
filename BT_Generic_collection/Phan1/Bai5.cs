using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Tên: Nguyễn Tấn Chinh
// MSV: 2415053122301
// Lớp:: 225LTC01
namespace BT_Generic_Bai5
{
    internal class Bai5
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<string> dsSinhVien = new List<string> { "An", "Bình", "Cường", "Hoa" };

            Console.WriteLine("DANH SÁCH SINH VIÊN HIỆN TẠI:");
            foreach(string sv in dsSinhVien)
            {
                Console.WriteLine(sv);
            }

            Console.Write("\nNhập tên sinh viên cần xóa khỏi danh sách: ");
            string tenXoa = Console.ReadLine();

            bool ketQua = dsSinhVien.Remove(tenXoa);

            if (ketQua)
                Console.WriteLine($"==> Đã xóa thành công sinh viên: {tenXoa}");
            else
                Console.WriteLine($"==> Không tìm thấy sinh viên '{tenXoa}' để xóa.");

            // 5. In lại danh sách sau khi xóa
            Console.WriteLine("\nDANH SÁCH SAU KHI CẬP NHẬT:");
            foreach (string sv in dsSinhVien)
            {
                Console.WriteLine(sv);
            }

            Console.ReadKey();
        }
    }
}
