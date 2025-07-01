using System;
using System.Text;

public static class StringCompressor
{
    public static string Compress(string input)
    {
        if (string.IsNullOrEmpty(input))
            return "";

        StringBuilder result = new StringBuilder();
        int count = 1;

        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] == input[i - 1])
            {
                count++;
            }
            else
            {
                result.Append(input[i - 1]);
                if (count > 1)
                    result.Append(count);
                count = 1;
            }
        }

        result.Append(input[input.Length - 1]);
        if (count > 1)
            result.Append(count);

        return result.ToString();
    }
}
