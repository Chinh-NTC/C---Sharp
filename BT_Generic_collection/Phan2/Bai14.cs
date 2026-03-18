using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Tên: Nguyễn Tấn Chinh
// MSV: 2415053122301
// Lớp:: 225LTC01
namespace BT_Generic_Bai14
{
    class Student
    {
        public int Id;
        public string Name;

        public Student(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
    internal class Bai14
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<Student> dsSinhVien = new List<Student>
            {
                new Student(101, "Nguyễn Văn An"),
                new Student(102, "Trần Thị Bình"),
                new Student(103, "Lê Văn Cường")
            };

            Console.WriteLine("DANH SÁCH SINH VIÊN:");
            foreach (var s in dsSinhVien) Console.WriteLine($"- ID: {s.Id} | Tên: {s.Name}");

            Console.Write("\nNhập mã ID sinh viên muốn xóa: ");
            int idXoa = int.Parse(Console.ReadLine());

            Student svCanXoa = null;

            foreach (Student sv in dsSinhVien)
            {
                if (sv.Id == idXoa)
                {
                    svCanXoa = sv; 
                    break;  
                }
            }

            if (svCanXoa != null)
            {
                dsSinhVien.Remove(svCanXoa);
                Console.WriteLine($"==> Đã xóa thành công sinh viên có ID: {idXoa}");
            }
            else
                Console.WriteLine($"==> Không tìm thấy sinh viên nào có mã ID: {idXoa}");

            Console.WriteLine("\nDANH SÁCH SAU KHI CẬP NHẬT:");
            foreach (var s in dsSinhVien) Console.WriteLine($"- ID: {s.Id} | Tên: {s.Name}");

            Console.ReadKey();
        }
    }
}
