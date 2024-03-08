using System;

namespace Project4
{
    public sealed class TwoDimensionalArray<T> : BaseArray<T>
    {
        private T[,] array;
        
        public TwoDimensionalArray(bool getFromUser, ValueProvider<T> input_provider) : base(getFromUser, input_provider) {}

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

        protected override void GetRandom()
        {
            Random random = new Random();
            int width = random.Next(2, 6);
            int length = random.Next(2, 6);
            array = new T[width, length];
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    array[i, j] = provider.Generate();
                }
            }
        }

        protected override void GetFromUser()
        {
            Console.Write("Получение двумерного массива с клавиатуры, введите длину: ");
            int length = int.Parse(Console.ReadLine());
            Console.Write("Введите ширину: ");
            int width = int.Parse(Console.ReadLine());
            array = new T[width, length];
            Console.WriteLine("Вводите значения:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = provider.ConvertFromString(Console.ReadLine());
                }
            }
        }
    }
}
