using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    public class Manager : Person, IEmployee
    {

        private String fac;
        private Position position;
        private int acct;

        public Manager(String name, String lastname, String patronomic, DateTime birthdate, String fac, Position position):
            base(name, lastname, patronomic, birthdate)
        {
            this.fac = fac;
            this.position = position;
        }

        public void getSalary()
        {
            {
                acct += position.Salary();
                Console.WriteLine($"{Getlastname()} {Getname()} {Getpatronomic()} получил зарплату!");
            }
        }

        public int takeFromAcct(int amount)
        {
            if (acct < 0)
            {
                Console.WriteLine($"не возможно снять со счёта {Getlastname()} {Getname()} {Getpatronomic()}. Счёт: {acct}");
                return acct;
            }
            else
            {
                acct -= amount;
                return 0;
            }
        }
        public override String toString()
        {
            return $"{position.Name()}\n{base.toString()}\nфакультет: {fac}, счёт{acct}";
        }
    }
}
