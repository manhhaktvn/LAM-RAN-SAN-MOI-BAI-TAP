using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAM_RAN_SAN_MOI_BAI_TAP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxwidth = 20;
            int maxheight = 20;
            for(int i=0;i<=maxwidth+1; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write("#");
                Console.SetCursorPosition(i, maxheight+1);
                
                Console.Write("#");
            }   
            for( int i =0;i<maxheight+1;i++)
            { Console.SetCursorPosition(0, i);
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write("#");
                Console.SetCursorPosition(maxwidth+1, i);
                
                Console.Write("#");
            }
            Console.BackgroundColor = ConsoleColor.Black;
            
            int middleX = (maxwidth / 2)+1;
            int middleY = (maxheight / 2)+1;
            Console.SetCursorPosition(middleX, middleY);
            Console.Write("o");
            
            
            int curentX = middleX;
            int curentY = middleY;
            while (true)
            {
                Console.SetCursorPosition(curentX, curentY);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("");


                ConsoleKeyInfo userKey = Console.ReadKey();
                switch (userKey.Key)
                {
                    case ConsoleKey.UpArrow:
                        curentY--;
                        break;
                    case ConsoleKey.DownArrow:
                        curentY++;
                        break;
                    case ConsoleKey.LeftArrow:
                        curentX--;
                        break;
                    case ConsoleKey.RightArrow:
                        curentX++;
                        break;
                }
                Console.SetCursorPosition(curentX, curentY);
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write("o");
                                if (curentX == 0 || curentX == maxwidth || curentY == 0 || curentY == maxheight)
                {

                    break;

                }
                
            }
                Console.Clear();
                Console.Write("game over");
                            Console.ReadKey();
           
            
        }
    }
}
