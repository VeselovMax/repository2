using System;

namespace Project4
{
    public class RandomString : RandomType<string>
    {
        string[] letters = new string[] {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o"};
        public override string Generate()
        {
            string randomString = letters[random.Next(0, 15)] + letters[random.Next(0, 15)] + letters[random.Next(0, 15)];
            return randomString;
        }
    }
}