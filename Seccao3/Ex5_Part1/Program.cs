using System;
using System.Globalization;

namespace Ex5_Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            int pieceCode1;
            int pieceCode2;
            double quantity1, unityValue1, quantity2, unityValue2, totalValue;

            string[] piece = Console.ReadLine().Split(' ');

            pieceCode1 = int.Parse(piece[0]);
            quantity1 = double.Parse(piece[1]);
            unityValue1 = double.Parse(piece[2], CultureInfo.InvariantCulture);

            string[] piece2 = Console.ReadLine().Split(' ');
            pieceCode2 = int.Parse(piece2[0]);
            quantity2 = double.Parse(piece2[1]);
            unityValue2 = double.Parse(piece2[2], CultureInfo.InvariantCulture);

            totalValue = (quantity1 * unityValue1) + (quantity2 * unityValue2);

            Console.WriteLine($"Value to be paid: R$ {totalValue.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}
