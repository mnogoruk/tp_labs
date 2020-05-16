using System;

namespace MyClass
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Progression p1 = new ArithmeticProgression(1, 3);
                Progression p2 = new GeometricProgression(3, 2);

                Console.WriteLine(p1.GetElement(3));
                Console.WriteLine(p2.GetElement(2));

            }
            {
                Publisher publ = new Publisher("Наука и жизнь", "nauka@mail.ru", 1234, new DateTime(2014, 12, 14)) ;
                Book b2 = new Book("Толстой Л.Н.", "Война и мир", publ, 1234, 2013, 101, true);
                b2.TakeItem();
                b2.Print();
                Magazine mag1 = new Magazine("О природе", 5, "Земля и мы", 2014, 1235, true);
                mag1.TakeItem();
                mag1.Print();
                Console.WriteLine("\n Тестирование полиморфизма");
                b2.ReturnSrok();
                Item it;
                it = b2;
                it.TakeItem();
                it.Return();
                it.Print();
                it = mag1;
                it.TakeItem();
                it.Return();
                it.Print();
            }

        }
    }
}
