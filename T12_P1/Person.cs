using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T12_P1
{
    internal class Person
    {
        public string name;
        public string surname;
        public int age;
        public Person()
        {
            name = "Alex";
            surname = "Borland";
            age = 20;
        
        }

        public Person(string name,string surname,int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }


        public string GetInfo()
        {
            return $"{name}\n{surname}\n{age}\n";
        }
        
    }
}
