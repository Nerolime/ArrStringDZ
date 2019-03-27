using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите какие-нибудь символы ");
            Console.WriteLine("Чтобы закончить нажмите . ");

            int SpaceCounter = 0;
            char symbols;
            do
            {
                symbols = char.Parse(Console.ReadLine());
                if (symbols == ' ')
                {
                    SpaceCounter++;
                }
            }
            while (symbols != '.');


            Console.Write("Количество пробелов равно: " + SpaceCounter);
            


            int OneHundredThousand = 100000, TenThousand = 10000, Thousand = 1000, Hundred = 100, Ten = 10;
            Console.WriteLine("Введите 6 значное число");

            int number = int.Parse(Console.ReadLine());


            int[] array = new int[6];
            array[0] = (number / OneHundredThousand);
            array[1] = ((number % OneHundredThousand) / TenThousand);
            array[2] = ((number % OneHundredThousand) % TenThousand) / Thousand;
            array[3] = (((number % OneHundredThousand) % TenThousand) % Thousand) / Hundred;
            array[4] = ((((number % OneHundredThousand) % TenThousand) % Thousand) % Hundred) / Ten;
            array[5] = ((((number % OneHundredThousand) % TenThousand) % Thousand) % Hundred) % Ten;
            if (array[0] + array[1] + array[2] == array[3] + array[4] + array[5])
            {
                Console.WriteLine("Число счастливое");
            }
            else
            {
                Console.WriteLine("Не счастливое");
            }
            



            int numberA, numberB;
            Console.WriteLine("Введите число A");
            numberA = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число B");
            numberB = int.Parse(Console.ReadLine());
            for (int i = numberA; i <= numberB; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" " + i);
                }
                Console.WriteLine();
            }
            


            string numberN;
            Console.WriteLine("Введите число N. Число должно быть больше нуля");
            numberN = Console.ReadLine();

           
            
                for (int i=numberN.Length-1;i>=0;i--)
                {
                    Console.Write(numberN[i]);
                }

            Console.ReadLine();
            
        }
    }

}
