using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PacmanConsole
{
    public class Pacman
    {
        public int x = 1;
        public int y = 1;
        private int currentPacman = 0;
        private bool moved = false;


        string[,] pacmanRight = new string[,] {{@" .--. "}, 
                                               {@"/ _.-'"},
                                               {@"\  '-."},
                                               {@" '--' "}};
        string[,] pacmanFull = new string[,] {{@" .--. "},
                                              {@"/    \"},
                                              {@"\    /"},
                                              {@" '--' "}};
       
        string[,] pacmanLeft = new string[,] {{@" .--. "},
                                              {@"'-._ \"},
                                              {@".-'  /"},
                                              {@" '--' "}};

        string[,] pacmanUp = new string[,]   {{@" .  . "},
                                              {@"/ \/ \"},
                                              {@"\    /"},
                                              {@" '--' "}};

        string[,] pacmanDown = new string[,] {{@" .--. "},
                                              {@"/    \"},
                                              {@"\ /\ /"},
                                              {@" '  ' "}};


        public Pacman() 
        {

        }
        public bool Movement(int direction,Map map)
        {
            bool check = false;
            if (map.CheckTable(direction,this.x, this.y) == true)
            {
                check = map.CheckFood(direction, this.x, this.y);
                if (direction == 1)
                {
                    this.moved = true;                        
                    this.x++;
                }
                else if (direction == 2)
                {
                    this.moved = true;                        
                    this.x--;                    
                }
                else if (direction == 3)
                {
                    this.y++;
                    this.moved = true;
                }
                else if (direction == 4 && y - 1 > 0)
                {
                    this.y--;
                    this.moved = true;
                }
                
            }
            else
            {
                moved = false;
            }

            SetPacman(direction);
            return check;
        }
        
        public void InitPacman(int _x, int _y)
        {
            this.x = _x;
            this.y = _y;
        }


        public void SetPacman(int direction)
        {
            if(currentPacman == 0)
            {
                currentPacman = 1;
                if (direction == 1 || direction == 0)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        Console.SetCursorPosition(x, y + i);
                        Console.Write(pacmanRight[i, 0]);
                    }
                    Clear(direction);
                }
                if (direction == 2)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        Console.SetCursorPosition(x, y + i);
                        Console.Write(pacmanLeft[i, 0]);
                        
                    }
                    Clear(direction);
                }
                if (direction == 3)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        Console.SetCursorPosition(x, y + i);
                        Console.Write(pacmanDown[i, 0]);
                        
                    }
                    Clear(direction);
                }
                if (direction == 4)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        Console.SetCursorPosition(x, y + i);
                        Console.Write(pacmanUp[i, 0]);
                        
                    }
                    Clear(direction);
                }
            }
            else
            {
                currentPacman = 0;
                for (int i = 0; i < 4; i++)
                {
                    Console.SetCursorPosition(x, y + i);
                    Console.Write(pacmanFull[i, 0]);
                    
                }
                Clear(direction);
            }
            

        }
        public void Clear(int direction)
        {
            if(this.moved == true)
            {
                if (direction == 1)
                {
                    Console.SetCursorPosition(x - 1, y + 2);
                    Console.Write(" ");
                    Console.SetCursorPosition(x - 1, y + 1);
                    Console.Write(" ");
                }
                if (direction == 2)
                {
                    Console.SetCursorPosition(x + 6, y + 2);
                    Console.Write(" ");
                    Console.SetCursorPosition(x + 6, y + 1);
                    Console.Write(" ");
                }
                if (direction == 3)
                {
                    Console.SetCursorPosition(x + 1, y - 1);
                    Console.Write(" ");
                    Console.SetCursorPosition(x + 2, y - 1);
                    Console.Write(" ");
                    Console.SetCursorPosition(x + 3, y - 1);
                    Console.Write(" ");
                    Console.SetCursorPosition(x + 4, y - 1);
                    Console.Write(" ");
                }
                if (direction == 4)
                {
                    Console.SetCursorPosition(x + 1, y + 4);
                    Console.Write(" ");
                    Console.SetCursorPosition(x + 2, y + 4);
                    Console.Write(" ");
                    Console.SetCursorPosition(x + 3, y + 4);
                    Console.Write(" ");
                    Console.SetCursorPosition(x + 4, y + 4);
                    Console.Write(" ");
                }
            }
            

        }
    }
}
