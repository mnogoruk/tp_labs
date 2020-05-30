using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using School;
namespace Corparation
{
    class Program
    {
        private delegate void SalaryGiver();
        private static event SalaryGiver salaryGiver = null;
        static void Main(string[] args)
        {

            
            List<Person> schoolEmployees = new List<Person>();
            List<Student> students = new List<Student>();

            Laboratory lab = new Laboratory("Optica");
            Admin admin = new Admin("Бог", "Vseya", "Rusi", new DateTime(1, 1, 1), 10000, lab);
            salaryGiver += admin.getSalary;
            schoolEmployees.Add(admin);

            Teacher teacher = new Teacher("Vera", "Muhoedova", "Dmitievna", new DateTime(1945, 3, 3), "Econom fac.", 20);
            salaryGiver += teacher.getSalary;
            schoolEmployees.Add(teacher);

            Position position = new Position("управлюзий", 1000);
            Manager manager = new Manager("OLeg", "Zososov", "Piramidovich", new DateTime(1987, 12, 31), "Econom fac.", position);
            salaryGiver += manager.getSalary;
            schoolEmployees.Add(manager);

            Student student1 = new Student("Daniil", "Litvinenko", "Dmitrievich", new DateTime(2001, 05, 31), "IKT", "K3121");
            students.Add(student1);
            Student student2 = new Student("FEEf", "ninayuuuu", "Javavich", new DateTime(2000, 12, 12), "FIKT", "RE3112");
            students.Add(student2);


            foreach(Person p in schoolEmployees)
            {
                p.Print();
                Console.WriteLine();
            }

            foreach(Student s in students)
            {
                s.Print();
                Console.WriteLine();
            }

            Console.WriteLine("press any button for selary");
            Console.ReadLine();
            getSalaryAll();
        }
        static void getSalaryAll()
        {
            if (salaryGiver != null)
            {
                Console.WriteLine("ВСЕМ ЗАРПЛАТА!");
                salaryGiver();
            }
        }
    }
}
