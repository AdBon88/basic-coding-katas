using System;
namespace basic_coding_katas {
    public class TimesTable {

        public static void PrintTimesTable() {

            int n;

            Console.WriteLine("Enter a number from 1 - 12 to generate a times table for:");

            while (!Int32.TryParse(Console.ReadLine(), out n) && n > 0 && n <= 12) {
                Console.WriteLine("Invalid entry! Please enter a number from 1 to 12");
            }

            for (int i = 1; i <= 12; i++) {
                Console.WriteLine($"{i} x {n} = {i * n}");
            }
        }
    }
}
