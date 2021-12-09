using System;

namespace _2dmodel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите высоту: ");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите ширину: ");
            int width = int.Parse(Console.ReadLine());

            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
