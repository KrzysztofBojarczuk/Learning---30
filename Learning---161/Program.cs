using System;
using System.IO;

namespace Learning___161
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Calc();
                    Console.WriteLine("Jesli chcesz zakończyć program wpisz Tak / tak. Jeśli chcesz dalej kontynować wciśjnij inny przycisk:");
                    string end = Console.ReadLine();
                    if (end == "Tak" || end == "tak" || end == "tAk" || end == "tAk")
                    {
                        break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.Clear();

            }
        }

        private static void Calc()
        {
            Console.WriteLine("Rachunek w resturacji!");
            Console.WriteLine("Wprwoadź cene posiłku:");
            double price = double.Parse(Console.ReadLine());

            double tax = 0.0675;
            double tip = 0.2;

            double resultTip = price * tip;
            double resultTax = price * tax;

            decimal result = (decimal)resultTip + (decimal)resultTax + (decimal)price;
            Console.WriteLine($"Wysokość rachunku wynosi {result.ToString("c")}.");
            Console.WriteLine($"Wysokość napiwku wynosi {resultTax.ToString("c")}.");
            Console.WriteLine($"Wysokość podatku wynosi {resultTip.ToString("c")}.");
            StreamWriter inpudDate = File.CreateText("Numbers.text");
            inpudDate.WriteLine($"Wysokość rachunku wynosi {result.ToString("c")}.");
            inpudDate.WriteLine($"Wysokość podatku wynosi {resultTax.ToString("c")}.");
            inpudDate.WriteLine($"Wysokość napiwku wynosi {resultTip.ToString("c")}.");
            inpudDate.Close();
        }
    }
}
