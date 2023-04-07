using System.Collections;

namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(3, "Tural", "Cafarov", 5);
            Console.WriteLine($"Name:{student.Name},Surname:{student.Surname},Id:{student.Id},{student.CodeEmail}");
            student.GenerateEmail();
            Student.CheckName("tural");
            

           

        }
    }
}