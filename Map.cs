using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanConsole
{
    public class Map
    {
        public int x = 26;
        private int[,] possiblePosition = new int[,] { { 1, 1 },{ 7, 1 },{ 13, 1 },{ 19, 1 },{ 25, 1 },{ 31, 1 },{ 37, 1 },{ 49, 1 },{ 55, 1 },{ 61, 1 },{ 67, 1 },{ 73, 1 },{ 79, 1 },{ 85, 1 },
                                                      { 1, 5 },{ 19, 5 },{ 37, 5 },{ 49, 5 },{ 67, 5 },{ 85, 5 },
                                                      { 1, 9 },{ 19, 9 },{ 37, 9 },{ 49, 9 },{ 67, 9 },{ 85, 9 },
                                                      { 1, 13 },{ 7, 13 },{ 13, 13 },{ 19, 13 },{ 25, 13 },{ 31, 13 },{ 37, 13 },{ 43, 13 },{ 49, 13 },{ 55, 13 },{ 61, 13 },{ 67, 13 },{ 73, 13 },{ 79, 13 },{ 85, 13 },
                                                      { 1, 17 },{ 19, 17 },{ 67, 17 },{ 85, 17 },
                                                      { 1, 21 },{ 7, 21 },{ 13, 21 },{ 19, 21 },{ 25, 21 },{ 31, 21 },{ 37, 21 },{ 49, 21 },{ 55, 21 },{ 61, 21 },{ 67, 21 },{ 73, 21 },{ 79, 21 },{ 85, 21 }};
        private int[,] deletedPositions = new int[96,26];


        private string[,] mapTable = new string[,] {{"--------------------------------------------------------------------------------------------    ================    "},
                                                    {"|                                          |    |                                          |    | score:       |    "},
                                                    {"| .-.   .-.   .-.   .-.   .-.   .-.   .-.  |    | .-.   .-.   .-.   .-.   .-.   .-.   .-.  |    ================    "},
                                                    {"| '-'   '-'   '-'   '-'   '-'   '-'   '-'  |    | '-'   '-'   '-'   '-'   '-'   '-'   '-'  |                        "},
                                                    {"|                                          |    |                                          |                        "},
                                                    {"|      ------------      ------------      |    |      ------------      ------------      |                        "},
                                                    {"| .-.  |          | .-.  |          | .-.  |    | .-.  |          | .-.  |          | .-.  |                        "},
                                                    {"| '-'  |          | '-'  |          | '-'  |    | '-'  |          | '-'  |          | '-'  |                        "},
                                                    {"|      |          |      |          |      |    |      |          |      |          |      |                        "},
                                                    {"|      |          |      |          |      |    |      |          |      |          |      |                        "},
                                                    {"| .-.  |          | .-.  |          | .-.  |    | .-.  |          | .-.  |          | .-.  |                        "},
                                                    {"| '-'  |          | '-'  |          | '-'  |    | '-'  |          | '-'  |          | '-'  |                        "},
                                                    {"|      ------------      ------------      ------      ------------      ------------      |                        "},
                                                    {"|                                                                                          |                        "},
                                                    {"| .-.   .-.   .-.   .-.   .-.   .-.   .-.   .-.   .-.   .-.   .-.   .-.   .-.   .-.   .-.  |                        "},
                                                    {"| '-'   '-'   '-'   '-'   '-'   '-'   '-'   '-'   '-'   '-'   '-'   '-'   '-'   '-'   '-'  |                        "},
                                                    {"|                                                                                          |                        "},
                                                    {"|      ------------      ------------------------------------------      ------------      |                        "},
                                                    {"| .-.  |          | .-.  |                                        | .-.  |          | .-.  |                        "},
                                                    {"| '-'  |          | '-'  |                                        | '-'  |          | '-'  |                        "},
                                                    {"|      ------------      ------------------      ------------------      ------------      |                        "},
                                                    {"|                                          |    |                                          |                        "},
                                                    {"| .-.   .-.   .-.   .-.   .-.   .-.   .-.  |    | .-.   .-.   .-.   .-.   .-.   .-.   .-.  |                        "},
                                                    {"| '-'   '-'   '-'   '-'   '-'   '-'   '-'  |    | '-'   '-'   '-'   '-'   '-'   '-'   '-'  |                        "},
                                                    {"|                                          |    |                                          |                        "},
                                                    {"--------------------------------------------------------------------------------------------                        "}};

        public Map(Pacman pacman, Ghost ghost, Ghost ghostHard, int difficulty)
        {

            DrawMap();
            AddCharactersToMap(pacman,ghost, ghostHard, difficulty);

        }
        public void DrawMap()
        {
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < 26; i++)
            {
                Console.WriteLine(mapTable[i, 0]);
            }

        }
        public bool CheckTable(int direction, int x, int y)
        {
            if (direction == 1)
            {
                if ((mapTable[y, 0][x + 6] != '-' && mapTable[y, 0][x + 6] != '|' && mapTable[y + 3, 0][x + 6] != '|' && mapTable[y + 3, 0][x + 6] != '-') == true)
                {
                    return true;
                }
            }
            if (direction == 2)
            {
                if ((mapTable[y, 0][x - 1] != '-' && mapTable[y, 0][x - 1] != '|' && mapTable[y + 3, 0][x - 1] != '|' && mapTable[y + 3, 0][x - 1] != '-') == true)
                {
                    return true;
                }
            }
            if (direction == 3)
            {
                if ((mapTable[y + 4, 0][x] != '-' && mapTable[y + 4, 0][x] != '|' && mapTable[y + 4, 0][x + 5] != '|' && mapTable[y + 4, 0][x + 5] != '-') == true)
                {
                    return true;
                }
            }
            if (direction == 4)
            {
                if ((mapTable[y - 1, 0][x] != '-' && mapTable[y - 1, 0][x] != '|' && mapTable[y - 1, 0][x + 5] != '|' && mapTable[y - 1, 0][x + 5] != '-') == true)
                {
                    return true;
                }
            }
            return false;

        }
        public void AddCharactersToMap(Pacman pacman, Ghost ghost, Ghost ghostHard, int difficulty)
        {
            int i = 0;
            var rnd = new Random();
            if(difficulty != 2)
            {
                var numbers = Enumerable.Range(0, 59).OrderBy(x => rnd.Next()).Take(2).ToList();
                foreach (var number in numbers)
                {
                    ++deletedPositions[possiblePosition[number, 0] + 1, possiblePosition[number, 1]];
                    if (i == 0)
                    {
                        pacman.InitPacman(possiblePosition[number, 0], possiblePosition[number, 1]);
                        i++;
                    }
                    else
                    {
                        ghost.InitGhost(possiblePosition[number, 0], possiblePosition[number, 1]);

                    }
                }
            }
            else
            {
                var numbers = Enumerable.Range(0, 59).OrderBy(x => rnd.Next()).Take(3).ToList();
                for(int j = 0; j < 3; j++)
                {
                    ++deletedPositions[possiblePosition[numbers[j], 0] + 1, possiblePosition[numbers[j], 1]];
                    if (j == 0)
                    {
                        pacman.InitPacman(possiblePosition[numbers[j], 0], possiblePosition[numbers[j], 1]);
                    }
                    if (j == 1)
                    {
                        ghost.InitGhost(possiblePosition[numbers[j], 0], possiblePosition[numbers[j], 1]);
                    }
                    if (j == 2)
                    {
                        ghostHard.InitGhost(possiblePosition[numbers[j], 0], possiblePosition[numbers[j], 1]);
                    }
                }
            }
            
            

        }
        public void FixFood(int direction, int x, int y)
        {
            if (direction == 1)
            {
                if (mapTable[y + 1, 0][x - 1] == '.' && deletedPositions[x - 1, y] == 0 && deletedPositions[x - 3, y] == 0)
                {
                    Console.SetCursorPosition(x - 1, y + 1);
                    Console.Write(".");
                    Console.SetCursorPosition(x - 1, y + 2);
                    Console.Write("'");
                }
                if (mapTable[y + 1, 0][x - 1] == '-' && deletedPositions[x - 2, y] == 0)
                {
                    Console.SetCursorPosition(x - 1, y + 1);
                    Console.Write("-");
                    Console.SetCursorPosition(x - 1, y + 2);
                    Console.Write("-");
                }

            }
            if (direction == 2)
            {
                if (mapTable[y + 1, 0][x + 6] == '.' && deletedPositions[x + 4, y] == 0 && deletedPositions[x + 6, y] == 0)
                {
                    Console.SetCursorPosition(x + 6, y + 1);
                    Console.Write(".");
                    Console.SetCursorPosition(x + 6, y + 2);
                    Console.Write("'");
                }
                if (mapTable[y + 1, 0][x + 6] == '-' && deletedPositions[x + 5, y] == 0)
                {
                    Console.SetCursorPosition(x + 6, y + 1);
                    Console.Write("-");
                    Console.SetCursorPosition(x + 6, y + 2);
                    Console.Write("-");
                }
            }
            if (direction == 3)
            {
                if (mapTable[y - 1, 0][x + 1] == '.' && deletedPositions[x, y - 2] == 0)
                {
                    Console.SetCursorPosition(x + 1, y - 1);
                    Console.Write(".");
                    Console.SetCursorPosition(x + 2, y - 1);
                    Console.Write("-");
                    Console.SetCursorPosition(x + 3, y - 1);
                    Console.Write(".");
                }
                else if (mapTable[y - 1, 0][x + 2] == '-' && deletedPositions[x, y - 3] == 0)
                {
                    Console.SetCursorPosition(x + 1, y - 1);
                    Console.Write("'");
                    Console.SetCursorPosition(x + 2, y - 1);
                    Console.Write("-");
                    Console.SetCursorPosition(x + 3, y - 1);
                    Console.Write("'");
                }
            }
            if (direction == 4)
            {
                if (mapTable[y + 4, 0][x + 1] == '.' && deletedPositions[x, y + 1] == 0)
                {
                    Console.SetCursorPosition(x + 1, y + 4);
                    Console.Write(".");
                    Console.SetCursorPosition(x + 2, y + 4);
                    Console.Write("-");
                    Console.SetCursorPosition(x + 3, y + 4);
                    Console.Write(".");
                }
                else if (mapTable[y + 4, 0][x + 2] == '-' && deletedPositions[x, y + 3] == 0)
                {
                    Console.SetCursorPosition(x + 1, y + 4);
                    Console.Write("'");
                    Console.SetCursorPosition(x + 2, y + 4);
                    Console.Write("-");
                    Console.SetCursorPosition(x + 3, y + 4);
                    Console.Write("'");
                }
            }
        }

        public bool CheckFood(int direction, int x, int y)
        {
            
            if (direction == 1)
            {
                if (mapTable[y + 1, 0][x + 6] == '.' && (x + 4) % 6 == 0 && deletedPositions[x + 6, y] == 0)
                {
                    ++deletedPositions[x+6,y];
                    ClearFood(x, y,direction);
                    return true;
                }

            }
            if (direction == 2)
            {
                if (mapTable[y + 1, 0][x - 1] == '.' && (x - 5) % 6 == 0 && deletedPositions[x - 3, y] == 0)
                {
                    ++deletedPositions[x - 3, y];
                    ClearFood(x, y,direction);
                    return true;
                }
            }
            if (direction == 3)
            {
                if (mapTable[y + 4, 0][x + 1] == '.' && (x - 1) % 6 == 0 && deletedPositions[x + 1, y + 3] == 0)
                {
                    ++deletedPositions[x + 1 , y + 3];
                    ClearFood(x, y, direction);
                    return true;
                }
            }
            if (direction == 4)
            {
                if (mapTable[y - 2, 0][x + 1] == '.' && (x - 1) % 6 == 0 && deletedPositions[x + 1, y - 3] == 0)
                {
                    ++deletedPositions[x + 1, y - 3];
                    ClearFood(x, y, direction);
                    return true;
                }
            }
            
            return false;
        }
        public void ClearFood(int x, int y, int direction)
        {
            if(direction == 1)
            {
                Console.SetCursorPosition(x + 7, y + 1);
                Console.Write(" ");
                Console.SetCursorPosition(x + 8, y + 1);
                Console.Write(" ");
                Console.SetCursorPosition(x + 7, y + 2);
                Console.Write(" ");
                Console.SetCursorPosition(x + 8, y + 2);
                Console.Write(" ");
            }
            if(direction == 2)                
            {
                Console.SetCursorPosition(x - 2, y + 1);
                Console.Write(" ");
                Console.SetCursorPosition(x - 3, y + 1);
                Console.Write(" ");
                Console.SetCursorPosition(x - 2, y + 2);
                Console.Write(" ");
                Console.SetCursorPosition(x - 3, y + 2);
                Console.Write(" ");
            }
            if (direction == 3)
            {
                Console.SetCursorPosition(x + 1, y + 5);
                Console.Write(" ");
                Console.SetCursorPosition(x + 2, y + 5);
                Console.Write(" ");
                Console.SetCursorPosition(x + 3, y + 5);
                Console.Write(" ");
            }
            if (direction == 4)
            {
                Console.SetCursorPosition(x + 1, y - 2);
                Console.Write(" ");
                Console.SetCursorPosition(x + 2, y - 2);
                Console.Write(" ");
                Console.SetCursorPosition(x + 3, y - 2);
                Console.Write(" ");
            }

        }

}


}
