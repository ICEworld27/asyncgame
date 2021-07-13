using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asyncgame
{
    class Map
    {
        public int x;
        /*{
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
                
                else
                {
                    throw new IOException("Value was less then 0");
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
        Enemy enemy1;
        Enemy enemy2;
        Player player;
        public int[,] map;

        public Map(int x, int y)
        {
            this.x = x;
            this.y = y;
            enemy1 = new Enemy(1,1,this);
            enemy2 = new Enemy(2,2,this);
            player = new Player(0, 0, this);
            map = GenerateMap(x,y);
            
        }
        public Player GetPlayer()
        {
            return player;
        }
        int[,] GenerateMap(int n, int m)
        {
            int[,] map = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    map[i, j] = 0;
                }
            }
            map[player.y,player.x ] = 1;
            map[enemy1.y,enemy1.x] = 2;
            map[enemy2.y,enemy2.x] = 2;
            return map;
        }

        public override string ToString()
        {
            string res = "";
            for (int i = 0; i < y; i++)
            {
                res += "|";
                for (int j = 0; j < x; j++)
                {
                    if (map[j, i] == 1)
                    {
                        res += "+";
                    }
                    else
                    {
                        if (map[j, i] == 2)
                        {
                            res += "-";
                        }
                        else
                        {
                            res += " ";
                        }
                    }
                    res += "|";
                }
                res += "\n";
            }
            /*
            for (int i = x-1; i >= 0; i--)
            {
               res+="|";
                for (int j = 0; j < y; j++)
                {

                    if (map[i, j] == 1)
                    {
                        res += "+";
                    }
                    else
                    {
                        if (map[i, j] == 2)
                        {
                            res += "-";
                        }
                        else
                        {
                            res += " ";
                        }
                    }

                    res += "|";
                }
                res += "\n";
            }*/
            return res;
        }
        async public Task Run()
        {
            await enemy1.Move();
            await enemy2.Move();
            await player.Move();
        }
    }
}
