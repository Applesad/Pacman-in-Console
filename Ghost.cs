using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanConsole
{
    public class Ghost
    {
        public int x = 1;
        public int y = 1;
        private int direction = 0;
        private bool moved = false;
        private int amountMovedHorizontal = 0;
        private int amountMovedVertical = 0;

        string[,] ghostRight = new string[,] {{@",----."},
                                              {@"|  oo|"},
                                              {@"|  ~~|"},
                                              {@"|/\/\|"}};

        string[,] ghostLeft = new string[,]  {{@",----."},
                                              {@"|oo  |"},
                                              {@"|~~  |"},
                                              {@"|/\/\|"}};

        string[,] ghostVertical = new string[,]{{@",----."},
                                                {@"| oo |"},
                                                {@"| ~~ |"},
                                                {@"|/\/\|"}};


        public Ghost()
        {

        }
        public void InitGhost(int _x, int _y)
        {
            this.x = _x;
            this.y = _y;
        }
        public void SetDir(Map map)
        {
            if(amountMovedHorizontal == 6 || direction == 0 || amountMovedVertical == 4)
            {
                amountMovedHorizontal = 0;
                amountMovedVertical = 0;
                Random rand = new Random();
                direction = rand.Next(1, 5);
                while (map.CheckTable(direction, this.x, this.y) == false)
                {
                    Random rnd = new Random();
                    direction = rnd.Next(1, 5);
                }
            }


        }
        
        public void GhostMovement(Map map)
        {
            SetDir(map);
            if (direction == 1)
            {
                this.moved = true;
                this.x++;
                amountMovedHorizontal++;
            }
            else if (direction == 2)
            {
                this.moved = true;
                this.x--;
                amountMovedHorizontal++;
            }
            else if (direction == 3)
            {
                this.y++;
                this.moved = true;
                amountMovedVertical++;
            }
            else if (direction == 4 && y - 1 > 0)
            {
                this.y--;
                this.moved = true;
                amountMovedVertical++;
            }
            else
            {
                moved = false;
            }
            SetGhost(direction);
            map.FixFood(direction,x,y);
        }
        public void SetGhost(int direction)
        {
            if (direction == 1 || direction == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.SetCursorPosition(x, y + i);
                    Console.Write(ghostRight[i, 0]);
                    
                }
                Clear(direction);
            }
            if (direction == 2)
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.SetCursorPosition(x, y + i);
                    Console.Write(ghostLeft[i, 0]);
                    
                }
                Clear(direction);
            }
            if (direction == 3 || direction == 4)
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.SetCursorPosition(x, y + i);
                    Console.Write(ghostVertical[i, 0]);
                   
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
                    Console.SetCursorPosition(x - 1, y);
                    Console.Write(" ");
                    Console.SetCursorPosition(x - 1, y + 1);
                    Console.Write(" ");
                    Console.SetCursorPosition(x - 1, y + 2);
                    Console.Write(" ");
                    Console.SetCursorPosition(x - 1, y + 3);
                    Console.Write(" ");
                }
                if (direction == 2)
                {
                    Console.SetCursorPosition(x + 6, y);
                    Console.Write(" ");
                    Console.SetCursorPosition(x + 6, y + 1);
                    Console.Write(" ");
                    Console.SetCursorPosition(x + 6, y + 2);
                    Console.Write(" ");
                    Console.SetCursorPosition(x + 6, y + 3);
                    Console.Write(" ");
                }
                if (direction == 3)
                {
                    Console.SetCursorPosition(x, y - 1);
                    Console.Write(" ");
                    Console.SetCursorPosition(x + 1, y - 1);
                    Console.Write(" ");
                    Console.SetCursorPosition(x + 2, y - 1);
                    Console.Write(" ");
                    Console.SetCursorPosition(x + 3, y - 1);
                    Console.Write(" ");
                    Console.SetCursorPosition(x + 4, y - 1);
                    Console.Write(" ");
                    Console.SetCursorPosition(x + 5, y - 1);
                    Console.Write(" ");
                }
                if (direction == 4)
                {
                    Console.SetCursorPosition(x, y + 4);
                    Console.Write(" ");
                    Console.SetCursorPosition(x + 1, y + 4);
                    Console.Write(" ");
                    Console.SetCursorPosition(x + 2, y + 4);
                    Console.Write(" ");
                    Console.SetCursorPosition(x + 3, y + 4);
                    Console.Write(" ");
                    Console.SetCursorPosition(x + 4, y + 4);
                    Console.Write(" ");
                    Console.SetCursorPosition(x + 5, y + 4);
                    Console.Write(" ");
                }
            }
            
        }

    }
}
