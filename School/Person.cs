using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;

namespace School
{
    public class Person
    {
        private static int counter;
        private string name;
        private string lastname;
        private string patronomic;
        private DateTime birthdate;
        private int globalID;
        static Person()
        {
            counter = 0;
        }

        public Person(String name, String lastname, String patronomic, DateTime birthdate)
        {
            this.Setname(name);
            this.Setlastname(lastname);
            this.Setpatronomic(patronomic);
            this.birthdate = birthdate;
            this.globalID = counter++;
        }

        public void Print()
        {
            Console.WriteLine(this.toString());
        }

        public virtual String toString()
        {
            return $"ФИО: {Getname()} {Getlastname()} {Getpatronomic()}\nДата рождения: {birthdate}";
        }


        public string Getname()
        {
            return name;
        }

        public void Setname(string value)
        {
            name = value;
        }

        public string Getlastname()
        {
            return lastname;
        }

        public void Setlastname(string value)
        {
            lastname = value;
        }

        public string Getpatronomic()
        {
            return patronomic;
        }

        public void Setpatronomic(string value)
        {
            patronomic = value;
        }

        public DateTime Birthdate { get => birthdate; }

    }
}
