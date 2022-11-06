using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PacmanConsole
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            bool eaten = false;
            bool gameProgress = false;
            int selectedClass = Menu.ShowMenu(true, "Łatwy", "Normalny", "Trudny");
            int direction=0;
            int gameSpeed = selectedClass == 0 ? 200 : 150;
            Pacman pacman = new Pacman();
            Ghost ghost = new Ghost();
            Ghost ghostHard = new Ghost();
            Map map = new Map(pacman, ghost, ghostHard, selectedClass);
            int score = 0;

            while (gameProgress == false)
            {
                gameProgress = Properties.GameTik(score, gameSpeed,selectedClass);
                
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo _Key = Console.ReadKey();
                    switch (_Key.Key)
                    {

                        case ConsoleKey.RightArrow:
                            direction = 1;

                            break;

                        case ConsoleKey.LeftArrow:
                            direction = 2;

                            break;

                        case ConsoleKey.DownArrow:
                            direction = 3;

                            break;

                        case ConsoleKey.UpArrow:
                            direction = 4;

                            break;


                    }
                }

                eaten = pacman.Movement(direction, map);
                ghost.GhostMovement(map);
                if(selectedClass == 2)ghostHard.GhostMovement(map);

                if (eaten == true) score = score + 10 * (selectedClass+1);
                if (Properties.CheckForPacman(pacman, ghost) == true)
                {
                    break;
                }
            }
            GameOver.EndScreen(score, gameProgress);
            Console.ReadLine();
        }
        
    }

}
