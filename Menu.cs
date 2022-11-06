using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanConsole
{
    public class Menu
    {
           
        public static int ShowMenu(bool canCancel, params string[] options)
        {
            /*
             _ __   __ _  ___ _ __ ___   __ _ _ __  
            | '_ \ / _` |/ __| '_ ` _ \ / _` | '_ \ 
            | |_) | (_| | (__| | | | | | (_| | | | |
            | .__/ \__,_|\___|_| |_| |_|\__,_|_| |_|
            |_| 
        
             */

            /*
             *  ,----. 
             *  |  oo|
             *  |  ~~|
             *  |/\/\|
             *  
             *   .--. 
             *  / _.-'
             *  \  '-.
             *   '--' 
             *   
             *   .-.
             *   '-'
            */

            Console.WriteLine(@" _ __   __ _  ___ _ __ ___   __ _ _ __");
            Console.WriteLine(@"| '_ \ / _` |/ __| '_ ` _ \ / _` | '_ \");
            Console.WriteLine(@"| |_) | (_| | (__| | | | | | (_| | | | |");
            Console.WriteLine(@"| .__/ \__,_|\___|_| |_| |_|\__,_|_| |_|"); //40
            Console.WriteLine(@"|_|");
            Console.WriteLine();

            Console.WriteLine("    - - - - - - - - - - - - - - - -");
            Console.WriteLine("    |  Wybierz poziom trudności   |");
            Console.WriteLine("    |                             |");
            Console.WriteLine("    |                             |");
            Console.WriteLine("    | ======= ========== ======== |");
            Console.WriteLine("    | |     | |        | |      | |");
            Console.WriteLine("    | ======= ========== ======== |");
            Console.WriteLine("    - - - - - - - - - - - - - - - -");

            Console.WriteLine();
            Console.WriteLine(@",----.      .--.                         ");
            Console.WriteLine(@"|  oo|     / _.-'    .-.    .-.    .-.   ");
            Console.WriteLine(@"|  ~~|     \  '-.    '-'    '-'    '-'   ");
            Console.WriteLine(@"|/\/\|      '--'                         ");

            const int optionsAmount = 3;
            int startX = 7;
            int startY = 11;
            int distOptions = 3;
            int currentSelection = 0;

            ConsoleKey key;

            Console.CursorVisible = false;

            do
            {
                for (int i = 0; i < options.Length; i++)
                {
                    if (i == 0)
                    {
                        Console.SetCursorPosition(startX, startY);
                    }
                    if (i == 1)//11
                    {
                        Console.SetCursorPosition(startX + options[i - 1].Length + distOptions, startY);
                    }
                    if (i == 2)//22
                    {
                        Console.SetCursorPosition(startX + options[i - 2].Length + distOptions + options[i - 1].Length + distOptions, startY);
                    }

                    if (i == currentSelection)
                        Console.ForegroundColor = ConsoleColor.Red;

                    Console.Write(options[i]);

                    Console.ResetColor();
                }

                key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                        if (currentSelection % optionsAmount > 0) currentSelection--;
                        else currentSelection = optionsAmount - 1;
                            
                        break;
                    case ConsoleKey.RightArrow:
                        if (currentSelection % optionsAmount < optionsAmount - 1) currentSelection++;
                        else currentSelection = 0;

                            break;
                    case ConsoleKey.Escape:
                        Environment.Exit(0);

                        break;
                }

            } while (key != ConsoleKey.Enter);

            Console.CursorVisible = true;
            Console.Clear();
            return currentSelection;


        }
        

        
    }
}
