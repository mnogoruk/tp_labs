using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    public class Admin : Person, IEmployee
    {
        private int salary;
        private int acct;
        private Laboratory laboratory;
     
        public Admin(String name, String lastname, String patronomic, DateTime birthdate, int salary, Laboratory lab) :
            base(name, lastname, patronomic, birthdate)
        {
            this.salary = salary;
            this.acct = 0;
            this.laboratory = lab;
        }
        
        public void getSalary()
        {
            if (laboratory.IsWorking())
            {
                acct += salary;
                Console.WriteLine($"{Getlastname()} {Getname()} {Getpatronomic()} получил зарплату!");
            }
        }

        public int takeFromAcct(int amount)
        {
            if (amount > acct)
            {
                acct = 0;
                return amount - acct;
            }
            else
            {
                acct -= amount;
                return 0;
            }
        }

        public override String toString()
        {
            return $"Администритор\n{base.toString()}\nСчёт: {acct}, зарплата: {salary}";
        }
    }
}
