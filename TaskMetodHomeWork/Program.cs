using System;

namespace TaskMetodHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1 : Ededin reqemlerinin cemi
            Console.Write("Eded daxil edin: ");
            int num = int.Parse(Console.ReadLine());
            var result = SumNumbers(num);
            Console.WriteLine($"Edein reqemlerin cemi : {result}");

            //Task2 : 2 eded araliqinda 21 e bolunen ededlerin ededi ortasinin hesablanmasi
            Console.Write("1 ci ededi daxil edin : ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("2 ci ededi daxil edin : ");
            int number2 = int.Parse(Console.ReadLine());
            var result2 = AvarageNumbers(number1, number2);
            Console.WriteLine(result2);

            //Task3: verilmis yazida 'a' herfinin olub olmadiginin yoxlannilmasi
            Console.Write("Yazi daxil edin : ");
            string word = Console.ReadLine();
            var result3 =WantedElement(word);
            Console.WriteLine(result3);




        }

        static int SumNumbers(int number)
        {
            int digit = 0;
            int sum = 0;
            while (number != 0)
            {
                digit = number % 10;
                number = number / 10;
                sum += digit;
            }
            return sum;
        }

        static double AvarageNumbers(int num1, int num2)
        {
            int sum = 0;
            double count = 0;
            if (num1 < num2)
            {
                for (int i = num1; i < num2; i++)
                {
                    if (i % 21 == 0)
                    {
                        sum += i;
                        count++;
                    }
                }


            }
            else
            {
                for (int i = num2; i < num1; i++)
                {
                    if (i % 21 == 0)
                    {
                        sum += i;
                        count++;
                    }
                }
            }
            if (count > 0)
            {
                return sum / count;
            }
            else
            {
                return 0;
            }

        }
        static string WantedElement(string str)
        {
            bool hasWantedA = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a')
                {
                    hasWantedA = true;
                    break;
                }
            }
            if (hasWantedA==true)
            {
                return "a herfi var";
            }
            else
            {
                return "a herfi yoxdur";
            }
        }
            

    }
}
