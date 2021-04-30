using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsJoural
{
    class Student
    {
        private string name;
        private string surname;
        private string group;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Group { get => group; set => group = value; }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Student s = (Student)obj;
                return (Name == s.Name) && (Surname == s.Surname);
            }
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Surname, Group);
        }
    }
}
