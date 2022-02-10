using System;

namespace ClassWork
{
    class Program
    {
        static void Main()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int summ = 0;
            if (a > 0)
            {
                for (int i = 0; i < a + 1; i++)
                {
                    summ += i;
                }
            }
            else
            {
                for (;a <= 1; a++)
                {
                    summ += a;
                }
            }
            Console.WriteLine(summ);
        }
    }
}
