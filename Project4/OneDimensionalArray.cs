using System;

namespace Project4
{
    public sealed class OneDimensionalArray : BaseArray, IOneDimensionalArray
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

        void IOneDimensionalArray.DeleteElementsBiggerThan100()
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] <= 100 && array[i] >= -100)
                {
                    count += 1;
                }
            }
            int[] new_array = new int[count];
            int count2 = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] <= 100 && array[i] >= -100)
                {
                    new_array[count2] = array[i];
                    count2++;
                }
            }
            array = new_array;
        }

        void IOneDimensionalArray.DeleteRepeating()
        {
            int count = 0;
            bool isUnique = true;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (i > j && array[i] == array[j])
                    {
                        isUnique = false;
                    }
                }
                if (isUnique)
                {
                    count++;
                }
                isUnique = true;
            }
            int[] new_array = new int[count];
            int count1 = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (i > j && array[i] == array[j])
                    {
                        isUnique = false;
                    }
                }
                if (isUnique)
                {
                    new_array[count1] = array[i];
                    count1++;
                }
                isUnique = true;
            }
            array = new_array;
        }
    }
}
