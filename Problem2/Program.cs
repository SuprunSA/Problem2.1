using System;
using static System.Console;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal input = decimal.Parse(ReadLine());
            WriteLine("Стоимость товара без НДС: {0}", Math.Round(input * 5 / 6, 2));
            WriteLine("Сумма НДС в чеке: {0}", Math.Round(input / 6, 2));
            WriteLine("Сумма НДС для налоговой декларации: {0}", Math.Floor(input/6));
        }
    }
}
