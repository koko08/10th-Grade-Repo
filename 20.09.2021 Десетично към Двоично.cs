using System;

namespace _20._09._2021_Упр
{
    class Program
    {
        static void Main(string[] args)
        {
            int desetichno = int.Parse(Console.ReadLine());
            string dvoichno = Convert.ToString(desetichno, 2);
            Console.WriteLine("dvoichno: " + dvoichno);
        }
    }
}
