using System;

namespace Project4
{
    public abstract class RandomType<T>
    {
        protected Random random = new Random();
        public abstract T Generate();
    }
}