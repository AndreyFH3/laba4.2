using System;

namespace lab4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int B = int.Parse(Console.ReadLine());
            int vari = int.Parse(Console.ReadLine());
            void pluss(int a, int b)
            {
                Console.WriteLine(a + b);
            }
            void minus(int a, int b)
            {
                Console.WriteLine(a - b);
            }
            void multy(int a, int b)
            {
                Console.WriteLine(a * b);
            }
            void devide(int a, int b)
            {
                double _1 = (double)a;
                double _2 = (double)b;
                Console.WriteLine(_1 / _2);
            }
        }  
    }
}
