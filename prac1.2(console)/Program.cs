using System;

namespace prac1._2_console_
{
    class Prac
    {
        private int a, b;
        private string chislo;
        private char[] bukva;
        private void inner()
        {
            Console.Write("Введите трёхзначное число:");
            chislo = Console.ReadLine();
            sravnenie();
        }
        private void sravnenie()
        {
            if (Int32.TryParse(chislo, out a) && chislo.Length == 3)
            {
                bukva = chislo.ToCharArray();
                a = Int32.Parse(bukva[0].ToString());
                b = Int32.Parse(bukva[1].ToString());
                if (a > b)
                {
                    Console.WriteLine("Первая цифра(" + a + ") больше второй(" + b + ")");
                }
                else if (a < b)
                {
                    Console.WriteLine("Вторая цифра(" + b + ") больше первой(" + a + ")");
                }
                else if (a == b)
                {
                    Console.WriteLine("Первая цифра(" + a + ") равна второй(" + b + ")");
                }
            }
            else
            {
                Console.WriteLine("Вы ввели не трёхзначное число");
                inner();
            }
        }
        public Prac()
        {
            inner();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Prac prac = new Prac();
        }
    }
}
