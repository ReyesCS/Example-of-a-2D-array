using System;

namespace TwoDArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] numberArray = new double[2, 10];

            SetArray(numberArray);
            DisplayResults(numberArray);
        }
        public static void SetArray(double[,] data1)
        {
            Random num = new Random();
            for (int x = 0; x < 10; x++)
            {
                data1[0, x] = num.Next(0, 100);
                data1[1, x] = Math.Pow(data1[0, x], 2);
            }
        }
        public static void DisplayResults(double [,] data1)
        {
            string msg = "";
            //create string to display to messagebox
            msg += "Random Values Squared\n" + "\nRandom\tNumber\n";
            msg += "Number    Squared\n";
            msg += "-----------------------\n";
            for (int y = 0; y < 10; y++)
            {
                msg += data1[0, y].ToString().PadRight(10, ' ') +
                    data1[1, y].ToString().PadLeft(10, ' ') + "\n";
            }
            Console.WriteLine(msg, "Squared Values ");
            Console.ReadLine();

        }
    }
}