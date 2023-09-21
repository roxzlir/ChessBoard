using System.Data;
using System.Drawing;

namespace ChessBoard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            int boardSize;

            while (true)
            {
                Console.Write("Välkommen, jag vill visa dig mitt schackbräde! Storlek får du bestämma genom att ange ett heltal upp till 50: ");
                string inputNumber = Console.ReadLine();

                if (int.TryParse(inputNumber, out boardSize) && boardSize >= 2 && boardSize <= 50)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Du gjorde en felaktig inmatning!");
                }
            }

            for (int row = 1; row <= boardSize; row++)
            {
                for (int column = 1; column <= boardSize; column++)
                {
                    if ((row + column) % 2 == 0)
                    {
                        Console.Write("◻︎");
                    }
                    else
                    {
                        Console.Write("◼︎");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}










//int globalCounter = 1;

//for (int row = 1; row <= size; row++)
//{
//    for (int column = 1; column <= size; column++)
//    {
//        if (globalCounter % 2 == 0)
//        {
//            Console.Write("A");
//        }
//        else
//        {
//            Console.Write("B");
//        }
//        globalCounter++;

//    }
//}









//int globalCounter = 1;

//for (int row = 1; row <= size; row++)
//{
//    for (int column = 1; column <= size; column++)
//    {
//        if (globalCounter % 2 == 0)
//        {
//            Console.Write(white);
//        }
//        else
//        {
//            Console.Write(black);
//        }
//        globalCounter++;
//    }
//}

