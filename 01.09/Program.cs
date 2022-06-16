using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person tom = new Person("Tom", 34) { name = "Bob", age = 29 };
            //Какое значение поля name будет иметь tom?

            #region Answer
            //Поле name объекта tom будет иметь значение "Bob".
            //В самом начале выполняется начальная инициализация полей класса,
            //и полю name присваивается значение "Sam".Далее выполняется
            //конструктор, который устанавливает для переменной name значение
            //"Tom".И в последнюю очередь выполняется инициализатор, который
            //устанавливает для поля name значение "Bob".
            Console.WriteLine(tom.name);
            #endregion

            Console.ReadLine();
        }
    }
    class Person
    {
        public string name = "Sam";
        public int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
