using System;

namespace Zad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2: ");
            string dv = Console.ReadLine();
            int dvc = Convert.ToInt32(dv, 2);
            Console.WriteLine(dvc);
            string sh = Console.ReadLine();
            int shc = Convert.ToInt32(sh, 16);
            Console.WriteLine(shc);
            int ans = dvc + shc;
            Console.WriteLine(ans);
        }
    }
}
