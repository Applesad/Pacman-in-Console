using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PacmanConsole
{
    public class Properties
    {

        public static bool CheckForPacman(Pacman pacman, Ghost ghost)
        {
            if((pacman.x - 5 == ghost.x || pacman.x + 5 == ghost.x) && Math.Abs(pacman.y - ghost.y) <= 3)
            {
                return true;
            }
            else if ((pacman.y - 3 == ghost.y || pacman.y + 3 == ghost.y) && Math.Abs(pacman.x - ghost.x) <= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
           

        }
        public static bool GameTik(int score, int gameSpeed, int scoreMultiplier)
        {
            Console.CursorVisible = false;
            Thread.Sleep(gameSpeed);
            Console.SetCursorPosition(105, 1);
            Console.Write(score);
            if(score/(scoreMultiplier+1) == 560)//560
            {
                return true;
            }
            else return false;
        }
    }
}
