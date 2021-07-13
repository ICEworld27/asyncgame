using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asyncgame
{
    class Player :Person
    {
        public Player(int x, int y, Map map):base(x,y,map)
        {
        }
        public override void go(int newX, int newY)
        {
            if (newX >= 0 && newX < map.x && newY >= 0 && newY < map.y)
            {
                int type = map.map[x, y]; ;
                if (map.map[newX, newY] == 0)
                {
                    map.map[x, y] = 0;
                    map.map[newX, newY] = type;
                    x = newX;
                    y = newY;
                }
                else
                {
                    if (map.map[newX, newY] != type)
                    {
                        map.map[x, y] = 0;
                        Console.WriteLine("You lost!");
                    }
                }
            }

        }

        public override async void Move()
        {
            //TODO make move
            while (y != map.y-1 && x != map.x-1 )
            {
                await go_right();
                Console.WriteLine(map);
            }
            Console.WriteLine("You win!");
        }


    }
}

