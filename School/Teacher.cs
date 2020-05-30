using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    public class Teacher : Person, IEmployee
    {
        private static Position position;

        private String fac;
        private int exp;
        private int acct;
        
        static Teacher()
        {
            position = Position.TeacherPosition();
        }

        public Teacher(String name, String lastname, String patronomic, DateTime birthdate, String fac, int exp): 
            base(name, lastname, patronomic, birthdate)
        {
            this.fac = fac;
            this.exp = exp;
            this.acct = 0;
        }
        public void getSalary()
        {
            acct += (int)(position.Salary() * (exp + 10)) / 10;
            Console.WriteLine($"{Getlastname()} {Getname()} {Getpatronomic()} получил зарплату в {(position.Salary() * (exp + 10)) / 10}$");
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
            return $"{position}\n{base.toString()}\nфакультет: {fac}, стаж: {exp}";
        }
    }
}
