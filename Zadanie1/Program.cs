class Program
{
    static void Main()
    {
        string original = "aaabbcccdde";
        string compressed = StringCompressor.Compress(original);
        Console.WriteLine("Сжатая строка: " + compressed); // a3b2c3d2e

        string decompressed = StringDecompressor.Decompress(compressed);
        Console.WriteLine("Восстановленная строка: " + decompressed); // aaabbcccdde
    }
}
