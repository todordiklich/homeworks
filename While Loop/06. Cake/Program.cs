using System;

namespace _06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int caceWidth = int.Parse(Console.ReadLine());
            int caceLengh = int.Parse(Console.ReadLine());
            int caceSize = caceLengh * caceWidth;
            int onePieceSize = 1;
            int piecesSize = 0;

            while (true)
            {
                string numberOfPieces = Console.ReadLine();
                
                if (numberOfPieces == "STOP")
                {
                    Console.WriteLine($"{caceSize - piecesSize} pieces are left.");
                    break;
                }
                int numberPieces = int.Parse(numberOfPieces);
                piecesSize += numberPieces * onePieceSize;
                if (caceSize <= piecesSize)
                {
                    Console.WriteLine($"No more cake left! You need {piecesSize - caceSize} pieces more.");
                    break;
                }
            }
        }
    }
}
