using System;

namespace Project4
{
    public sealed class OneDimensionalArray : BaseArray
    {
        private int[] array;

        public OneDimensionalArray(bool getFromUser) : base(getFromUser) { }

        public override void Print()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine("");
        }

        protected override void GetFromUser()
        {
            Console.WriteLine("Получение одномерного массива с клавиатуры, введите длину");
            int length = int.Parse(Console.ReadLine());
            array = new int[length];
            Console.WriteLine("Вводите значения");
            for (int i = 0; i < array.Length; i++)
            {
                int value = int.Parse(Console.ReadLine());
                array[i] = value;
            }
        }

        protected override void GetRandom()
        {
            Random random = new Random();
            int length = random.Next(2, 6);
            array = new int[length];
            for (int i = 0; i < array.Length; i++)
            {
                int value = random.Next(0, 10);
                array[i] = value;
            }
        }

        public override decimal GetAverageValue()
        {
            decimal sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum / array.Length;
        }
    }
}
