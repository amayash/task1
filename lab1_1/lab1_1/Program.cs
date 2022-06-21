using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число(максимум 5 разрядов):");
            int n1 = Convert.ToInt32(Console.ReadLine());
            if (n1 > 99999) Console.WriteLine("Не подходит");
            Console.WriteLine("Введите второе число:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            if (n2 > 99999) Console.WriteLine("Не подходит");
            Console.WriteLine("Введите третье число:");
            int n3 = Convert.ToInt32(Console.ReadLine());
            if (n3 > 99999) Console.WriteLine("Не подходит");

            int sum1 = 0;
            while (n1 != 0 && n1 <= 99999)
            {
                //Суммирование цифр числа
                sum1 += (n1 % 10);
                n1 /= 10;
            }
            int sum2 = 0;
            while (n2 != 0 && n2 <= 99999)
            {
                sum2 += (n2 % 10);
                n2 /= 10;
            }
            int sum3 = 0;
            while (n3 != 0 && n3 <= 99999)
            {
                sum3 += (n3 % 10);
                n3 /= 10;
            }
            if ((sum1 + sum2 + sum3) % (sum1 - sum2) == 0)
                Console.WriteLine("Делится");
            else Console.WriteLine("Не делится");
            Console.ReadLine();
        }
    }
}
