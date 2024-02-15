using System;

namespace Project2
{
    public abstract class BaseArray
    {
        public BaseArray(bool getFromUser)
        {
            Create(getFromUser);
        }

        public abstract void Print();

        public virtual void Create(bool getFromUser)
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
    }
}