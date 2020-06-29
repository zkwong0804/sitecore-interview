using System;
using System.Collections;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int width = 5;
            const int height = 5;
            int[,] fields = new int[height, width]
                {
                    {0,1,0,0,0},
                    {0,0,1,0,0},
                    {0,0,0,1,0},
                    {0,0,0,1,0},
                    {0,0,1,0,0},
                };

            ArrayList safePath = new ArrayList();
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (fields[y, x] == 1)
                    {
                        if (safePath.Count <= 0)
                        {
                            int[] good = { x, y };
                            safePath.Add(good);
                            Console.WriteLine($"Totoshka go [{y},{x}]");
                        }
                        else
                        {
                            int[] last = (int[])safePath[safePath.Count - 1];
                            Console.WriteLine($"Ally go [{last[1]},{last[0]}]");
                            if (x == last[0] || x == last[0] - 1 || x == last[0] + 1)
                            {
                                int[] good = { x, y };
                                safePath.Add(good);
                                Console.WriteLine($"Totoshka go [{y},{x}]");
                            }


                        }
                    }
                }
            }

            Console.WriteLine($"Totoshka is safe!");
            Console.WriteLine($"Ally is safe!");

        }
    }
}
