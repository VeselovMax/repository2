using System;

namespace Project3
{
    public abstract class BaseArray : IBaseArray
    {
        public BaseArray(bool getFromUser)
        {
            Create(getFromUser);
        }

        public void Create(bool getFromUser)
        {
            if (getFromUser)
            {
                GetFromUser();
            }
            else
            {
                GetRandom();
            }
        }

        protected abstract void GetFromUser();

        protected abstract void GetRandom();

        public abstract decimal GetAverageValue();

        public abstract void Print();
    }
}
