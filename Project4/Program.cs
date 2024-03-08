using System;

namespace Project4
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrinter[] objects = new IPrinter[8];
            IntegerProvider intProvider = new IntegerProvider();
            BooleanProvider boolProvider = new BooleanProvider();
            DoubleProvider doubleProvider = new DoubleProvider();
            StringProvider stringProvider = new StringProvider();
            Console.WriteLine("Вводить значения с клавиатуры?   yes/no");
            bool getFromUser = CheckFromUser();
            objects[0] = new OneDimensionalArray<int>(getFromUser, intProvider);
            objects[1] = new OneDimensionalArray<bool>(getFromUser, boolProvider);
            objects[2] = new OneDimensionalArray<double>(getFromUser, doubleProvider);
            objects[3] = new OneDimensionalArray<string>(getFromUser, stringProvider);
            objects[4] = new TwoDimensionalArray<int>(getFromUser, intProvider);
            objects[5] = new TwoDimensionalArray<bool>(getFromUser, boolProvider);
            objects[6] = new TwoDimensionalArray<double>(getFromUser, doubleProvider);
            objects[7] = new TwoDimensionalArray<string>(getFromUser, stringProvider);
            foreach (IPrinter obj in objects)
            {
                obj.Print();
                Console.WriteLine();
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
