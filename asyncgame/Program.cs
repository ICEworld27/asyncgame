using System;

namespace asyncgame
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("N: ");//x
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("M: ");//y
            int m = Convert.ToInt32(Console.ReadLine());
            Map map = new Map(n, m);
            //map.GetPlayer().Move();
            Console.WriteLine(map);
            map.Run();
            Console.WriteLine("assa");
            /*
            int[,] b = new Map(3, 2).map;
            int[,] a = { {5,10,55 },{ 20,50,60}};
            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write($"|{b[j, i]}|");
                }
                Console.WriteLine();
            }
            */
        }        
    }
}
