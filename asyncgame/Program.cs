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
            Map map = new Map(m, n);
            Console.WriteLine(map);
            Player player = map.GetPlayer();
            try
            {
                player.go_up();
                player.go_up();
                player.go_right();
                player.go_right();
                player.go_right();
                player.go_right();
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine("Player died");
            }
            
            Console.WriteLine(map);
        }        
    }
}
