using System;

namespace StudentsJoural
{
    class Program
    {
        static void Main(string[] args)
        {
            var j = new Journal();
            var s = new Student() { Name = "Alexander", Surname = "Petrov", Group = "G1" };

            j.AddStudent(s);
            Console.WriteLine($"{j.Students}");
            j.AddStudent(new Student() { Name = "Alexander", Surname = "Petrov", Group = "G2" });

            j.AddMarkToStudent(s, 20);
            Console.WriteLine($"{j.Students}");

            j.Print();
        }
    }
}
