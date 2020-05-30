using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace School
{
    public class Student: Person
    {
        private String fac;
        private String group;
        public Student(String name, String lastname, String patronomic, DateTime birthdate, String fac, String group):
            base(name, lastname, patronomic, birthdate)
        {
            this.fac = fac;
            this.group = group;
        }

        public override String toString()
        {
            return $"Ученик{base.toString()}\nфакультет: {fac}, группа: {group}";
        }

    }
}
