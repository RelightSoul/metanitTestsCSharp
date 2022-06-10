using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Tom",31,"tom@gmail.com");
            //Какое значения будут иметь поля name, age и email после
            //выполнения следующего кода и почему? В каком порядке будут
            //вызываться конструкторы класса Person?
        }
    }
    
    class Person
    {
        public string name = "Ben";
        public int age = 18;
        public string email = "ben@gmail.com";

        public Person() { }
        public Person(string name)
        {
            this.name = name;
        }
        public Person(string name, int age) : this(name)
        {
            this.age = age;
        }
        public Person(string name, int age, string email) : this("Bob", age)
        {
            this.email = email;
        }
    }
}
