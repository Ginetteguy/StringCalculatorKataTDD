using System;

namespace SimpleCalculator
{
    public class StringCalculator
    {
        public int Add(string input)
        {
            if (string.IsNullOrEmpty(input))
                return 0;

            string[] inputs = input.Split(',');
            int result = 0;
            Array.ForEach(inputs, delegate (string number) { result += Convert.ToInt32(number); });
            return result;
        }
    }
}
