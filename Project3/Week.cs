using System;

namespace Project3
{
    public class Week : IPrinter
    {
        void IPrinter.Print()
        {
            Console.WriteLine("понедельник, вторник, среда, четверг, пятница, суббота, воскресенье");
        }
    }
}
