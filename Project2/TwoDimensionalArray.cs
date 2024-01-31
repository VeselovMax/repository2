using System;

namespace Project2
{
    public sealed class TwoDimensionalArray : BaseArray
    {
        private int[,] array;

        public TwoDimensionalArray(bool getFromUser) : base(getFromUser)
        {
            Create(getFromUser);
        }

        public override void Print()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine("");
            }
        }

        private int[,] GetRandom()
        {
            Random random = new Random();
            int width = random.Next(2, 6);
            int length = random.Next(2, 6);
            int[,] array = new int[width, length];
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    array[i, j] = random.Next(0, 10);
                }
            }
            return array;
        }

        public override void Create(bool getFromUser)
        {
            if (getFromUser)
            {
                array = GetFromUser();
            }
            else
            {
                array = GetRandom();
            }
        }

        private int[,] GetFromUser()
        {
            Console.Write("Введите длину: ");
            int length = int.Parse(Console.ReadLine());
            Console.Write("Введите ширину: ");
            int width = int.Parse(Console.ReadLine());
            int[,] array = new int[width, length];
            Console.WriteLine("Вводите значения:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return array;
        }

        public override decimal GetAverageValue()
        {
            decimal sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }
            }
            return sum / array.Length;
        }

        public void PrintAsSnake()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write($"{array[i, j]} ");
                    }
                    else
                    {
                        Console.Write($"{array[i, array.GetLength(1) - j - 1]} ");
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}