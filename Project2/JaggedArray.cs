using System;

namespace Project2
{
    public sealed class JaggedArray : BaseArray
    {
        private int[][] array;

        public JaggedArray(bool getFromUser) : base(getFromUser)
        {
            Create(getFromUser);
        }

        private int[][] GetFromUser()
        {
            Console.Write("Введите кол-во ступеней: ");
            int height = int.Parse(Console.ReadLine());
            int[][] array = new int[height][];
            int length;
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Введите длину ступени: ");
                length = int.Parse(Console.ReadLine());
                array[i] = new int[length];
                Console.WriteLine("Вводите значения:");
                for (int j = 0; j < length; j++)
                {
                    array[i][j] = int.Parse(Console.ReadLine());
                }
            }
            return array;
        }

        private int[][] GetRandom()
        {
            Random random = new Random();
            int height = random.Next(2, 6);
            int[][] array = new int[height][];
            int length;
            for (int i = 0; i < height; i++)
            {
                length = random.Next(3, 10);
                array[i] = new int[length];
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = random.Next(0, 10);
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

        public void ChangeEven()
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] % 2 == 0)
                    {
                        array[i][j] = i * j;
                    }
                }
            }
        }

        public override decimal GetAverageValue()
        {
            int sum = 0;
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    sum += array[i][j];
                    count++;
                }
            }
            return sum / count;
        }

        public string GetAverageInnerValues()
        {
            string answer = "";
            decimal sum = 0;
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum = 0;
                count = 0;
                for (int j = 0; j < array[i].Length; j++)
                {
                    sum += array[i][j];
                    count++;
                }
                answer += Convert.ToString(sum / count);
                answer += " ";
            }
            return answer;
        }

        public override void Print()
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write($"{array[i][j]} ");
                }
                Console.WriteLine("");
            }
        }
    }
}