using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp21
{
    public class Student : ICodeAcademy
    {
        public static int Count = 0;
        public int _id ;
        public int Id { get { return _id ; } set { _id = value; } }
        public string Name ;
        public string Surname;
        public string CodeEmail { get; set ; }
        public Student(int id,string name,string surname,int count)
        {
            
            Count++;
            Id = Count;
            Name = name;
            Surname = surname;
            CodeEmail = $"{Name.ToLower()}.{Surname.ToLower()}{Id}";
            GenerateEmail();
            //CheckName("name");
        }



        public static bool CheckName(string name)
        {

            for (int i = 1; i < name.Length; i++)
            {
                if (Char.IsLetter(name[i]))
                {
                    Console.WriteLine(name[i]);
                    return true;
                }
            }

                if (name.Length > 3 && name.Length < 25)
                {
                    return true;
                }
                else { return false; }
            
        }

        public void GenerateEmail()
        {
            string emailname = $"{Name.ToLower()}.{Surname.ToLower()}{Id}";
            CodeEmail = $"CodeEmail:{emailname}@code.edu.az"; 
        }

       
    }
}
