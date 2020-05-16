using System;

namespace Utils
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            Console.WriteLine("Введите первое число:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            y = int.Parse(Console.ReadLine());

            int greater = Utils.Greater(x, y);
            Console.WriteLine("Большим из чисел {0} и {1} является {2} ", x, y, greater);

            Utils.Swap(ref x, ref y);
            Console.WriteLine("До swap: \t" + x + " " + y);
            Utils.Swap(ref x, ref y);
            Console.WriteLine("После swap: \t" + x + " " + y);

            int f;
            bool ok;

            Console.WriteLine("Number for factorial:");
            x = int.Parse(Console.ReadLine());


            // Test the factorial function
            ok = Utils.Factorial(x, out f);
            // Output factorial results
            if (ok)
                Console.WriteLine("Factorial(" + x + ") = " + f);
            else
                Console.WriteLine("Cannot compute this factorial");


            char anwer;
            Console.WriteLine("Равностороний - 1, Обычный - 2");
            anwer = Char.Parse(Console.ReadLine());

            if (anwer == '1')
            {
                Console.WriteLine("Введите значение стороны:");
                double a = Double.Parse(Console.ReadLine());
                double area = Operation.area(a);
                Console.WriteLine("Площадь треугольника: " + area);
            }
            else
            {
                Console.WriteLine("Введите значение первой стороны:");
                double a = Double.Parse(Console.ReadLine());
                Console.WriteLine("Введите значение второй стороны:");
                double b = Double.Parse(Console.ReadLine());
                Console.WriteLine("Введите значение третей стороны:");
                double c = Double.Parse(Console.ReadLine());
                try
                {
                    double area = Operation.area(a, b, c);
                    Console.WriteLine("Площадь треугольника: " + area);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Неверные значения сторон");
                }
 
            }
            double ca, cb, cc, x1, x2;
            Console.WriteLine("Введите коэффициента a: ");
            ca = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэффициента a: ");
            cb = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэффициента a: ");
            cc = Double.Parse(Console.ReadLine());
            int ans = Operation.squareRoot(ca, cb, cc, out x1, out x2);
            {
                    if (ans == 1)
                    {
                        Console.WriteLine("Корни уравнения с коэффициентами a = {0}, b = {1}, c = {2}\n" +
                            " равны x1 = {3}, x2 = {4}.", ca, cb, cc, x1, x2);
                    }
                    else if (ans == 0)
                    {
                        Console.WriteLine("Корнень уравнения с коэффициентами a = {0}, b = {1}, c = {2}\n" +
                            " равен x1 = x2 = {3}.", ca, cb, cc, x1);
                    }
                    else {
                        Console.WriteLine("Корней уравнения с коэффициентами a = {0}, b = {1}, c = {2} нет", ca, cb, cc);

                    }
        
            }
        }
    }
}
