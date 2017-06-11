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
            List<Bankomat.Account> listAcc = new List<Bankomat.Account>();
            while (true)
            {
                Console.WriteLine("У вас есть аккаунт?\n1. Создать новый\n2. Войти в существующий\nquit чтобы выйти");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1: createAccount(); break;
                    case 2: enterAccount(); break;
                }
                Console.ReadKey();
                Console.Clear();
            }
            void createAccount()
            {
                Console.WriteLine("Введите ваше имя: ");
                string name = (Console.ReadLine());
                Console.WriteLine("Введите вашу фамилию: ");
                string sname = (Console.ReadLine());
                Console.WriteLine("Введите ваш возраст: ");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите первоначальный взнос: ");
                double money = double.Parse(Console.ReadLine().Replace('.', ','));
                Bankomat.Account account = new Bankomat.Account(name, sname, age, money);
                listAcc.Add(account);
            }
            void blockAcc(int id)
            {
                foreach (var item in listAcc)
                {
                    if (item.getid(item) == id) //знаю, говнокод
                        item.blockAcc(item);    //знаю, говнокод
                }
            }
            void showMenu()
            {

            }
            bool checkAcc(int id, int pass) { return true; }

            void enterAccount()
            {
                while (true)
                {
                    Console.WriteLine("Введите id:");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите password:");
                    int password = int.Parse(Console.ReadLine());
                    int count = 3;
                    if (checkAcc(id, password) && count != 0)
                        showMenu();
                    else if (count == 0)
                    {
                        blockAcc(id);
                        break;
                    }
                    else
                    { Console.WriteLine("Некорректные данные\nОсталось попыток: " + count); count--; }


                }
            }


        }
    }
}
