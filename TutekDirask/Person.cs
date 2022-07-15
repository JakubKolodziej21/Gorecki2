using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutekDirask
{
    class Person : IEquatable<Person>
    {
        protected string name;
        protected int age;

        public string Name { get => name; }
        public int Age { get => age;}

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public bool Equals(Person other)
        {
            if(other == null)
            {
                return false;
            }

            if(other == this)
            {
                return true;
            }

            if(this.Name == other.Name && this.Age == other.Age)
            {
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return $"{this.Name} ({this.Age} y.o.)";
        }
    }
}
