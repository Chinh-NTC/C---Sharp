using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Tên: Nguyễn Tấn Chinh
// MSV: 2415053122301
// Lớp:: 225LTC01
namespace BT_Generic_Bai6
{
    internal class Bai6
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<string> danhSach = new List<string> { "C#", "Java", "Python", "JS", "SQL" };

            Console.WriteLine("Danh sách hiện tại: " + string.Join(", ", danhSach));

            Console.Write("\nNhập tên ngôn ngữ bạn muốn tìm: ");
            string tuKhoa = Console.ReadLine();
            bool timThay = danhSach.Contains(tuKhoa);
            if (timThay)
                Console.WriteLine($"==> Kết quả: '{tuKhoa}' CÓ tồn tại trong danh sách.");
            else
                Console.WriteLine($"==> Kết quả: '{tuKhoa}' KHÔNG tồn tại trong danh sách.");

            Console.ReadKey();
        }
    }
}
