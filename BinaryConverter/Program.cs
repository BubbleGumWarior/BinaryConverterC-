using System;

namespace BinaryConverter
{
    class Program
    {
        private static void Main(string[] args)
        {
            const int value = 10;
            var binary = Convert.ToString(value, 2);
 
            Console.WriteLine(binary);
        }
        public static string ToBinary(int x)
        {
            var character = new char[32];
 
            for (var i = 31; i >= 0 ; i--)
            {
                var pos = 1 << i;
                character[31 - i] = (x & pos) != 0 ? '1' : '0';
            }
            return new string(character);
        }
    }
}