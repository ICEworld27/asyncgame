using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asyncgame
{
    class Player :Person
    {
        List<Enemy> enemies;
        public Player(int x, int y, Map map,List<Enemy> enemies):base(x,y,map)
        {
            this.enemies = enemies;
        }
        public override async Task Move()
        {
            bool running = true;
            while (running)
            {
                if (map.map[x+1,y] != 2&&map.map[x,y] != 0)
                {
                    await go_up();
                    if (y == map.y - 1 || x == map.x - 1)
                    {
                        running = false;
                        Console.WriteLine("You win!");
                        for (int i = 0; i <enemies.Count; i++)
                        {
                            enemies[i].Stop();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("You lost!");
                    running = false;
                    for (int i = 0; i < enemies.Count; i++)
                    {
                        enemies[i].Stop();
                    }
                }
                Console.WriteLine(map);
            }
            
        }


    }
}

