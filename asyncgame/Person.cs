using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asyncgame
{
    abstract class Person
    {
        public int x;/*
        {
            get
            {
                return x;
            }
            set
            {
                if (value > 0)
                {
                    x = value;
                }
            }
        }*/
        public int y;/*
        {
            get
            {
                return y;
            }
            set
            {
                if (value > 0)
                {
                    y = value;
                }
            }
        }*/
        public Map map;
        public Person(int x, int y, Map map)
        {
            this.x = x;
            this.y = y;
            this.map = map;
        }
        void Move()
        {
            //TODO make move
        }

        public virtual void go(int newX, int newY)
        {
            if (newX >= 0 && newX < map.x && newY >= 0 && newY < map.y)
            {
                int type;
                if (map.map[newX, newY] == 0)
                {
                    type = map.map[x, y];
                    map.map[x, y] = 0;
                    map.map[newX, newY] = type;
                    x = newX;
                    y = newY;
                }
                else
                {

                }
            }
            
        }
        public void go_up()
        {
            int ny = y + 1;
            go(x, ny);

        }
        public void go_left()
        {
            int nx = x - 1;
            go(nx, y);
        }
        public void go_right()
        {
            int nx = x + 1;
            go(nx, y);
        }
        public void go_down()
        {
            int ny = y - 1;
            go(x, ny);
        }


    }
}
