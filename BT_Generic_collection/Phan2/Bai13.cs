using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Tên: Nguyễn Tấn Chinh
// MSV: 2415053122301
// Lớp:: 225LTC01
namespace BT_Generic_Bai13
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
    internal class Bai13
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<Student> dsSinhVien = new List<Student>
            {
                new Student(1, "Nguyễn Văn An"),
                new Student(2, "Trần Thị Bình"),
                new Student(3, "Lê Văn Cường")
            };

            Console.WriteLine("Danh sách sinh viên: ");
            foreach (var sv in dsSinhVien)
            {
                Console.WriteLine($"ID: {sv.Id}, Name: {sv.Name}");
            }
            int tongSoSV = dsSinhVien.Count;

            Console.WriteLine("----- THỐNG KÊ -----");
            Console.WriteLine($"Tổng số sinh viên có trong danh sách là: {tongSoSV}");

            Console.ReadKey();
        }
    }
}
