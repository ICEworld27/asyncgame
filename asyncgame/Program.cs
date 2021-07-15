using System;

namespace asyncgame
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello user!");
            Console.Write("Please enter value of N: ");//x
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter value of M: ");//y
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Use random mode? Y/N");
            Map map = new Map(n, m, false);
            if (Console.ReadLine() == "Y")
            {
                map= new Map(n, m);
            }
            Console.WriteLine(map);
            map.Run();
            Console.ReadKey();
        }        
    }
}
