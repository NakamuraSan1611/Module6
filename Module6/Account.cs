using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    class Account
    {
        private string name;
        private string sname;
        private int age;
        private int id;
        private int password;
        private double money;
        private bool isBlocked;
        public Account(string name, string sname, int age, double money)
        {
            this.name = name;
            this.sname = sname;
            this.age = age;
            this.id = Bankomat.Bank.getID();
            this.password = Bankomat.Bank.getPass();
            this.money = money;
            Console.WriteLine("Ваш аккаунт успешно создан!\nВаши полные данные:");
            Console.WriteLine("Имя:\t" + this.name + "\nФамилия:\t" + this.sname);
            Console.WriteLine("Возраст:\t" + this.age + "\nID:\t" + this.id);
            Console.WriteLine("Пароль:\t" + this.password + "\nПервоначальный взнос:\t" + this.money);
            Console.WriteLine("\n\n\n!!!\tВнимание! Запоните id и пароль они понадобятся для входа!\t!!!");
        }
        public double getMoney(Account acc)
        {
            return acc.money;
        }
        public int getid(Account acc)
        {
            return acc.id;
        }
        public void blockAcc(Account acc)
        {
            acc.isBlocked = true;
        }

    }
}
