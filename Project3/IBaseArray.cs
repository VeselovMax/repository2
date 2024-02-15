using System;

namespace Project3
{
    interface IBaseArray : IPrinter
    {
        void Create(bool getFromUser);

        decimal GetAverageValue();
    }
}
