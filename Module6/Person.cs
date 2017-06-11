using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Person
    {
        //1.	Создать два проекта в решении: библиотека классов и консольное приложение.
        //Подключить библиотеку в консольное приложение(сделал в одном проекте, так и не понял как связать
        //два проекта в одном решении).Добавить Класс Person в библиотеку и 
        //добавить класс со статическим методом который принимает в качестве параметра переменную 
        //типа Person и возвращает строку, состоящую из нескольких свойств класса Person.Вызвать 
        //в консольном приложении метод используя полное пространство имен при обращении к нему.

        private string name { get; set; }
        private string sname { get; set; }
        private int age { get; set; }
        static public string method1(Person person)
        {
            return person.name + "\t" + person.sname + "\t" + person.age;
        }
        public Person(string name, string sname, int age)
        {
            this.name = name;
            this.sname = sname;
            this.age = age;
        }

    }
}
