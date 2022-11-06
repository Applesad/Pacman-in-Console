using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PacmanConsole
{
    public class GameOver
    {
        public static void Freeze(int time)
        {
            Thread.Sleep(time);

        }
        public static void EndScreen(int score, bool gameWon)
        {
            Console.Clear();

            Console.WriteLine(@"   _____          __  __ ______    ______      ________ _____  ");
            Freeze(200);
            Console.WriteLine(@"  / ____|   /\   |  \/  |  ____|  / __ \ \    / /  ____|  __ \ ");
            Freeze(200);
            Console.WriteLine(@" | |  __   /  \  | \  / | |__    | |  | \ \  / /| |__  | |__) |");
            Freeze(200);
            Console.WriteLine(@" | | |_ | / /\ \ | |\/| |  __|   | |  | |\ \/ / |  __| |  _  / ");
            Freeze(200);
            Console.WriteLine(@" | |__| |/ ____ \| |  | | |____  | |__| | \  /  | |____| | \ \ ");
            Freeze(200);
            Console.WriteLine(@"  \_____/_/    \_\_|  |_|______|  \____/   \/   |______|_|  \_\");
            Freeze(200);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("            ======================================");
            Console.WriteLine("            | final score:                       |");   
            Console.WriteLine("            ======================================");
            Console.SetCursorPosition(27, 9);
            Freeze(500);
            Console.Write(score);
            if (gameWon == true) GameWon();
            else GameLost();

        }
        public static void GameWon()
        {
            Console.SetCursorPosition(0, 11);
            Console.WriteLine(@"     __     ______  _    _  __          ______  _   _   _ ");
            Console.WriteLine(@"     \ \   / / __ \| |  | | \ \        / / __ \| \ | | | |");
            Console.WriteLine(@"      \ \_/ / |  | | |  | |  \ \  /\  / / |  | |  \| | | |");
            Console.WriteLine(@"       \   /| |  | | |  | |   \ \/  \/ /| |  | | . ` | | |");
            Console.WriteLine(@"        | | | |__| | |__| |    \  /\  / | |__| | |\  | |_|");
            Console.WriteLine(@"        |_|  \____/ \____/      \/  \/   \____/|_| \_| (_)");

            Console.SetCursorPosition(3, 7);
            Console.Write(@" .--. ");
            Console.SetCursorPosition(3, 8);
            Console.Write(@"/ _.-'");
            Console.SetCursorPosition(3, 9);
            Console.Write(@"\  '-.");
            Console.SetCursorPosition(3, 10);
            Console.Write(@" '--' ");

            Console.SetCursorPosition(53, 7);
            Console.Write(@" .--. ");
            Console.SetCursorPosition(53, 8);
            Console.Write(@"'-._ \");
            Console.SetCursorPosition(53, 9);
            Console.Write(@".-'  /");
            Console.SetCursorPosition(53, 10);
            Console.Write(@" '--' ");
        }
        public static void GameLost()
        {
            Console.SetCursorPosition(0, 12);
            Console.WriteLine(@"    __     ______  _    _   _____ _____ ______ _____    _ ");
            Console.WriteLine(@"    \ \   / / __ \| |  | | |  __ \_   _|  ____|  __ \  | |");
            Console.WriteLine(@"     \ \_/ / |  | | |  | | | |  | || | | |__  | |  | | | |");
            Console.WriteLine(@"      \   /| |  | | |  | | | |  | || | | __ | | |  | | | |");
            Console.WriteLine(@"       | | | |__| | |__| | | |__| || |_| |____| |__| | |_|");
            Console.WriteLine(@"       |_|  \____/ \____/  |_____/_____|______|_____/  (_)");

            Console.SetCursorPosition(3, 7);
            Console.Write(@",----.");
            Console.SetCursorPosition(3, 8);
            Console.Write(@"|  oo|");
            Console.SetCursorPosition(3, 9);
            Console.Write(@"|  ~~|");
            Console.SetCursorPosition(3, 10);
            Console.Write(@"|/\/\|");

            Console.SetCursorPosition(53, 7);
            Console.Write(@",----.");
            Console.SetCursorPosition(53, 8);
            Console.Write(@"|oo  |");
            Console.SetCursorPosition(53, 9);
            Console.Write(@"|~~  |");
            Console.SetCursorPosition(53, 10);
            Console.Write(@"|/\/\|");
        }
    }
}
    