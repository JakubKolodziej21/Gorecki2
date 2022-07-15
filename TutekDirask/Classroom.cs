using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutekDirask
{
    class Classroom
    {
        private string name;
        private Person[] persons;
        public string Name { get => name; }

        public Classroom(string name, Person[] persons)
        {
            this.name = Name;
            this.persons = persons;
        }

        public override string ToString()
        {
            string result = "Classroom: " + this.Name + "\n";
            foreach(Person p in persons)
            {
                result += p.ToString() + "\n";
            }
            return result;
        }
    }
}
