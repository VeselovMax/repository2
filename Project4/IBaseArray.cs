using System;

namespace Project4
{
    interface IBaseArray : IPrinter
    {
        void Create(bool getFromUser);

        decimal GetAverageValue();
    }
}
