using System;

namespace Project3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool getFromUser;
            IBaseArray[] arrays = new IBaseArray[3];
            Console.WriteLine("Вводить массивы вручную?      yes/no");
            getFromUser = CheckFromUser();
            arrays[0] = new OneDimensionalArray(getFromUser);
            arrays[1] = new TwoDimensionalArray(getFromUser);
            arrays[2] = new JaggedArray(getFromUser);
            foreach (BaseArray array in arrays)
            {
                Console.WriteLine("");
                Console.WriteLine("Массив: ");
                array.Print();
                Console.WriteLine("Среднее значение: ");
                Console.WriteLine(array.GetAverageValue());
            }

            Console.WriteLine("-----------------------------------------------------------------------");

            IPrinter[] Objects = new IPrinter[4];
            Objects[0] = new Week();
            Objects[1] = new OneDimensionalArray(getFromUser);
            Objects[2] = new TwoDimensionalArray(getFromUser);
            Objects[3] = new JaggedArray(getFromUser);
            foreach (IPrinter obj in Objects)
            {
                Console.WriteLine("");
                obj.Print();
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
