using System;
namespace basic_coding_katas {
    public class NumberPrinter {

        public static void PrintNumbers() {

            int number;

            Console.WriteLine("Enter a number:");
            while (!Int32.TryParse(Console.ReadLine(), out number)) {
                Console.WriteLine("Please Enter an integer!");
            }

            for (int i = 1; i <= number; i++) {
                Console.WriteLine(i);
            }

        }
    }
}
