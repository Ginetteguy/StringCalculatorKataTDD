using System;

namespace SimpleCalculator
{
    public class StringCalculator
    {
        private readonly char[] Separators = { ',', '\n' };

        public int Add(string input)
        {
            if (string.IsNullOrEmpty(input))
                return 0;

            VerifyInputCorrectlyFormated(input);

            string[] inputs = input.Split(Separators);
            int result = 0;
            Array.ForEach(inputs, delegate (string number) { result += Convert.ToInt32(number); });
            return result;
        }

        private void VerifyInputCorrectlyFormated(string input)
        {
            Array.ForEach(Separators, delegate (char separator) { if (input.EndsWith(separator)) throw new ArgumentException(); });
        }
    }
}
