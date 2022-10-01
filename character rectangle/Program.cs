using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace character_rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word;
            char symbol;
            int frameLenght;
            int frameHeight = 3;
            int inderTop = 3;
            int inderLeft = 1;

            Console.Write("Введите слво: ");
            word = Console.ReadLine();
            Console.Write("Введите симвл: ");
            symbol = Convert.ToChar(Console.ReadLine());

            frameLenght = word.Length + 2;

            for(int i = 0; i < frameLenght; i++)
            {
                for(int j = 0; j < frameHeight; j++)
                {
                    Console.SetCursorPosition(i + inderLeft, j + inderTop);
                    Console.Write(symbol);
                }
            }

            Console.SetCursorPosition(inderLeft + 1, inderTop + 1);
            Console.Write(word);
            Console.SetCursorPosition(0, 0);
            Console.ReadKey();
        }
    }
}
