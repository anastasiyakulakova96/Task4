using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._2
{
    class Launcher
    {

        public static void Main()
        {
            Launcher launcher = new Launcher();
            string switchCase = "";

            while (!switchCase.Equals("3"))
            {
                Console.WriteLine("Please,choose what you want calculate: \n" + "1-FibonnachiNumbers\n" + "2-factirial\n" + "3-Exit");
                switchCase = Console.ReadLine();

                switch (switchCase)
                {
                    case "1":
                        launcher.CalculationFibonnachiNumbers();
                        break;
                    case "2":
                        launcher.CalculationFactorial();
                        break;
                    default:
                        Console.WriteLine("You enter don'y 1 or 2");
                        break;
                }
            }
        }

        public void CalculationFactorial()
        {
            Console.WriteLine("\n Please,enter number to factirial");
            string number = Console.ReadLine();
            long x = Int64.Parse(number);
            long result = 1;
            for (long i = 1; i <= x; i++)
            {
                result *= i;
            }
            Console.WriteLine("FACTORIAL= " + result + "\n");
        }


        public void CalculationFibonnachiNumbers()
        {
            Console.Write("Введите конец диапазона от 1 до : ");
            long end = Int64.Parse(Console.ReadLine());
            long j = 1;
            for (long i = 1; i <= end; i += j)
            {
                Console.Write("{0} ", i);
                j = i - j;
            }
            Console.WriteLine("\n");
        }
    }



    //class BigInteger {
       
    //     BigInteger FactFactor(int n)
    //    {
    //        if (n < 0)
    //            return 0;
    //        if (n == 0)
    //            return 1;
    //        if (n == 1 || n == 2)
    //            return n;
    //        bool[] u = new bool[n + 1]; // маркеры для решета Эратосфена
    //        List<Tuple<int, int>> p = new List<Tuple<int, int>>(); // множители и их показатели степеней
    //        for (int i = 2; i <= n; ++i)
    //            if (!u[i]) // если i - очередное простое число
    //            {
    //                // считаем показатель степени в разложении
    //                int k = n / i;
    //                int c = 0;
    //                while (k > 0)
    //                {
    //                    c += k;
    //                    k /= i;
    //                }
    //                // запоминаем множитель и его показатель степени
    //                p.Add(new Tuple<int, int>(i, c));
    //                // просеиваем составные числа через решето               
    //                int j = 2;
    //                while (i * j <= n)
    //                {
    //                    u[i * j] = true;
    //                    ++j;
    //                }
    //            }
    //        // вычисляем факториал
    //        BigInteger r = 1;
    //        for (int i = p.Count() - 1; i >= 0; --i)
    //            r *= BigInteger.Pow(p[i].Item1, p[i].Item2);
    //        return r;
    //    }
    //}
}
