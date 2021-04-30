using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsJoural
{
    class Journal
    {
        private List<Student> students;
        private Dictionary<Student, List<int>> marks;

        public List<Student> Students { get => students; set => students = value; }
        internal Dictionary<Student, List<int>> Marks { get => marks; set => marks = value; }

        public Journal()
        {
            Students = new List<Student>();
            Marks = new Dictionary<Student, List<int>>();
        }

        public void AddStudent(Student s)
        {
            students.Add(s);
            Marks.Add(s, new List<int>());
        }

        public void AddMarkToStudent(Student s, int m)
        {
            if (m < 0 && m > 100)
                throw new Exception();

            if(marks.ContainsKey(s))
                marks[s].Add(m);
            else
                throw new Exception();
        }

        public int AverageMarkByStudent(Student s)
        {
            if (marks.ContainsKey(s))
                return (int)marks[s].Average();
            else
                throw new Exception();
        }

        public void BadStudents()
        {
            foreach(var s in Students)
            {
                if(Marks[s].Any(i => i < 60))
                    Console.WriteLine($"Bad student: {s.Surname} {s.Name}, group: {s.Group}");
            }
        }

        public void Print()
        {
            foreach(var p in Marks)
            {
                Console.WriteLine($"Student: {p.Key.Surname} {p.Key.Name}, group: {p.Key.Group}");

                foreach(var m in p.Value)
                    Console.WriteLine($"\t{m}");

                Console.WriteLine();
            }
        }
    }
}
