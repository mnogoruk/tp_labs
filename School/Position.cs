using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    public class Position
    {

        private static Position teacherPosition; 

        private String name;
        private int salary;

        public Position(String name, int salary)
        {
            this.name = name;
            this.salary = salary;
        }

        public String Name()
        {
            return name;
        }
        public void Name(String name)
        {
            this.name = name;
        }

        public void Salary(int salary)
        {
            this.salary = salary;
        }

        public int Salary()
        {
            return salary;
        }

        public static Position TeacherPosition()
        {
            if(teacherPosition is null)
            {
               teacherPosition= new Position("Учитель", 5000);
            }
            return teacherPosition;
        }
    }
}
