using System;

namespace Project4
{
    public class RandomInteger : RandomType<int>
    {
        public override int Generate()
        {
            return random.Next(0, 101);
        }
    }
}