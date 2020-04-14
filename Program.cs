using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }   
    }
       class Student
    {
        public string LastName;
        public string FirstName;
        public string MiddleName;
        public int Birthyear;
        public string Addres;
        public Student(String LastName, String FirstName, String MiddleName, int Birthyear, string Addres)
        {
            this.LastName=LastName;
            this.FirstName=FirstName;
            this.MiddleName=MiddleName;
            this.Birthyear=Birthyear;
            this.Addres=Addres;
        }
        public void info(int sill)
        {
            System.Console.WriteLine($"LastNames:{this.LastName}");
            System.Console.WriteLine($"FirstName:{this.FirstName}");
            System.Console.WriteLine($"MiddleName:{this.MiddleName}");
            System.Console.WriteLine($"Birhtyear:{this.Birthyear}");
            System.Console.WriteLine($"Addres:{this.Addres}");
        }
    }
}
