using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число меньше 1001:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int chislo = n1;
            BigInteger n = new BigInteger(chislo);
            BigInteger rez = new BigInteger(chislo);
            for (int i = 1; i < n1; i++)
            {
                rez = BigInteger.Multiply(rez, n);
            }
            Console.WriteLine(n1 + "^" + n1 + "=" + rez);

            uint help;

            int[] counter = new int[10];

            while (!rez.Equals(0))
            {
                help = (uint)(BigInteger.Remainder(rez, 10));
                counter[help] += 1;
                rez = BigInteger.Divide(rez, 10);
            }
            Console.WriteLine("Нулей - " + counter[0] + ", единиц - " + counter[1] + ", двоек - " + counter[2] + ", троек - " + counter[3] +
                    ", четверок - " + counter[4] + ", пятерок - " + counter[5] + ", шестерок - " + counter[6] + ", семерок - " + counter[7] +
                    ", восьмерок - " + counter[8] + ", девяток - " + counter[9]);
            Console.ReadLine();
        }
    }
}
