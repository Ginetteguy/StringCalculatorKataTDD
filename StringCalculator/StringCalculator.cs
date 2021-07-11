using System;

namespace SimpleCalculator
{
    public class StringCalculator
    {
        public int Add(string input)
        {
            if (string.IsNullOrEmpty(input))
                return 0;

            return Convert.ToInt32(input);
        }
    }
}
