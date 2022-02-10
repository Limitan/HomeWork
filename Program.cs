using System;

class Programm
{
    static void Main()
    {
        string[] nums = Console.ReadLine().Split(' ');
        int a = int.Parse(nums[0]);
        int b = int.Parse(nums[1]);
        int c = int.Parse(nums[2]);
        if (a * b == c)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}
