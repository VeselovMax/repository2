using System;

namespace Project2
{
    class Program
    {
        private static void Main(string[] args)
        {
            bool getFromUser;
            BaseArray[] arrays = new BaseArray[3];
            Console.WriteLine("Ввести массивы вручную?      yes/no");
            getFromUser = CheckFromUser();
            arrays[0] = new OneDimensionalArray(getFromUser);
            arrays[1] = new TwoDimensionalArray(getFromUser);
            arrays[2] = new JaggedArray(getFromUser);
            foreach (BaseArray array in arrays)
            {
                Console.WriteLine("Массив: ");
                array.Print();
                Console.WriteLine("Среднее значение: ");
                Console.WriteLine(array.GetAverageValue());
            }
        }

        static bool CheckFromUser()
        {
            bool answer = false;
            bool incorrectAnswer = true;
            string input;
            while (incorrectAnswer)
            {
                input = Console.ReadLine();
                if (input == "yes")
                {
                    answer = true;
                    incorrectAnswer = false;
                }
                else if (input == "no")
                {
                    answer = false;
                    incorrectAnswer = false;
                }
                else
                {
                    Console.WriteLine("Вы ввели некорректный ответ! Попробуйте снова.");
                }
            }
            return answer;
        }
    }
}
