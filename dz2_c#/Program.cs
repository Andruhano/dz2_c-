using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace dz2_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 5;
            while (true)
            {
                // int k = _getch();
                ConsoleKeyInfo k = Console.ReadKey(true);
                //Console.Write(k.Key);
                //Console.Write(k.KeyChar);
                //Console.Write((int)k.Key);

                // система очистки консоли от одного символа в конкретных координатах
                Console.CursorLeft = x;
                Console.CursorTop = y;
                Console.Write(" ");

                if (k.Key == ConsoleKey.LeftArrow)
                {
                    //Console.WriteLine("LEFT");
                    x--;
                }
                else if (k.Key == ConsoleKey.RightArrow)
                {
                    //Console.WriteLine("RIGHT");
                    x++;
                }
                else if (k.Key == ConsoleKey.UpArrow)
                {
                    y--;
                }
                else if (k.Key == ConsoleKey.DownArrow)
                {
                    y++;
                }

                if (x < 0)
                {
                    x = 0;
                }
                else if (x >= Console.WindowWidth)
                {
                    x = Console.WindowWidth - 1;
                }

                if (y < 0)
                {
                    y = 0;
                }
                else if (y >= Console.WindowHeight)
                {
                    y = Console.WindowHeight - 1;
                }

                Console.CursorLeft = x;
                Console.CursorTop = y;
                // Console.Write(Convert.ToChar(0x256C));
                Console.WriteLine((char)1);
            }

            Thread.Sleep(15); // Sleep(15);
        }
    }
}
