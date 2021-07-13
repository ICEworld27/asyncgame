using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asyncgame
{
    abstract class Person
    {
        public int x;
        public int y;
        public Map map;
        public Person(int x, int y, Map map)
        {
            this.x = x;
            this.y = y;
            this.map = map;
        }
        async public virtual Task Move()
        {
            while (1 == 1)
            {
                await go_left();
                await go_down();
                await go_right();
                await go_up();

            }

        }

        async public Task go(int newX, int newY)
        {
            if (newX >= 0 && newX < map.x && newY >= 0 && newY < map.y)
            {
                int type;
                type = map.map[x, y];
                map.map[x, y] = 0;
                map.map[newX, newY] = type;
                x = newX;
                y = newY;
                
            }
            
        }
        async public Task go_up()
        {
            int ny = y + 1;
            await go(x, ny);

        }
        async public Task go_left()
        {
            int nx = x - 1;
            await go(nx, y);
        }
        async public Task go_right()
        {
            int nx = x + 1;
            go(nx, y);
        }
        async public Task go_down()
        {
            int ny = y - 1;
            await go(x, ny);
        }


    }
}
