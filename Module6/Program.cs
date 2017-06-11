using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6
{
    class Program
    {
        //если есть эта надпись значит я не доделал
        static void Main(string[] args)
        {
            //для задания 1. Описпание в классе Person
            Person.Person person = new Person.Person("MyName", "MySname", 25);
            Console.WriteLine(Person.Person.method1(person));

            //для задания 2. Описание в классе Task2
            Console.WriteLine(Task2.Task2.field1 + " " + Task2.Task2.field2 + " " + Task2.Task2.field3);

            while (true)
            {
                Console.WriteLine("У вас есть аккаунт?\n1. Создать новый\n2. Войти в существующий");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1: createAccount(); break;
                    case 2: enterAccount(); break;
                }
            }
            void createAccount()
            {
                Console.WriteLine("Введите ваше имя: ");
                string name = (Console.ReadLine());
                Bankomat.Account account1 = new Bankomat.Account("Name1", "Sname1", 25, 500000.500);
                Console.WriteLine(account1.getMoney(account1));
            }
            void enterAccount() { }

        }
    }
}
