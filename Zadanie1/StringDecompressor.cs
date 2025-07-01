using System;
using System.Text;

public static class StringDecompressor
{
    public static string Decompress(string input)
    {
        if (string.IsNullOrEmpty(input))
            return "";

        StringBuilder result = new StringBuilder();
        int i = 0;

        while (i < input.Length)
        {
            char currentChar = input[i];
            i++;

            StringBuilder countBuilder = new StringBuilder();
            while (i < input.Length && char.IsDigit(input[i]))
            {
                countBuilder.Append(input[i]);
                i++;
            }

            int count = 1;
            if (countBuilder.Length > 0)
                count = int.Parse(countBuilder.ToString());

            result.Append(new string(currentChar, count));
        }

        return result.ToString();
    }
}