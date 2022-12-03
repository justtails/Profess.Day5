using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profess.Day5
{
    class Program
    {
        static void Main(string[] args)
        {
            // while - цикл с предусловием

            //int a = 1;
            //Console.WriteLine($"Входное значение {a}");
            //while (a < 10)
            //{
            //    a = a * 2;
            //    Console.WriteLine(a);
            //}

            //Console.WriteLine($"Конечное значение: {a}");

            // for - цикл со счетчиком
            for (int i = 1; i < 10; i = i * 2)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
