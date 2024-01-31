using System;
using System.Diagnostics.Contracts;
namespace Project2
{
    public abstract class BaseArray
    {
        protected BaseArray(bool getFromUser)
        {
            Create(getFromUser);
        }

        public abstract void Print();

        public abstract void Create(bool getFromUser);
        
        public abstract decimal GetAverageValue();
    }
}