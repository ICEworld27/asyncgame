using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Random;
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
        Random random = new Random();
        public Map(int x, int y, bool randomeMode = true)
        {
            this.x = x;
            this.y = y;
            if (randomeMode)
            {
                enemy1 = new Enemy(random.Next(1, x), random.Next(1, y), this);
                enemy2 = new Enemy(random.Next(1, x), random.Next(1, y), this);
            }
            else
            {
                enemy1 = new Enemy(x/2,y/2,this);
                enemy2 = new Enemy(x/3,y/3,this);
            }


            List<Enemy> enemies = new List<Enemy>();
            enemies.Add(enemy1);
            enemies.Add(enemy2);
            player = new Player(0, 0, this,enemies);
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
            
            return res;
        }
        public void Run()
        {
            enemy1.Move();
            enemy2.Move();
            player.Move();

        }
    }
}
