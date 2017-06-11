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
        public Account(string name, string sname, int age, double money)
        {
            this.name = name;
            this.sname = sname;
            this.age = age;
            this.id = Bankomat.Bank.getID();
            this.password = Bankomat.Bank.getPass();
            this.money = money;
        }
        public double getMoney(Account acc)
        {
            return acc.money;
        }
    }
}
