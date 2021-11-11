using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
            //3.1 - базовый уровень - 8 вариант
        {
            try
            {
                Console.WriteLine("Введите число A:");
                double A = double.Parse(Console.ReadLine());
                double N = 1; double S = 0;
                do 
                {
                    
                    S += 1 / N;
                    N++;
                }
                while (S < A);
                Console.WriteLine("N={0}", N);
                Console.WriteLine("Сумма={0:F2}", S);

            }
            catch (Exception)
            {
                Console.WriteLine("Введите корректно переменную");
            }
       

        }
    }
    
}
