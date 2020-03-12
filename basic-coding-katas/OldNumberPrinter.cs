using System;
namespace basic_coding_katas {
    public class OldNumberPrinter {

        public static void PrintSumOfNumbers() {

            int number;

            Console.WriteLine("Enter a number:");
            while (!Int32.TryParse(Console.ReadLine(), out number)) {
                Console.WriteLine("Please Enter an integer!");
            }

            int sum = 0;
            for (int i = 1; i <= number; i++) {
                sum += i;
            }

            Console.WriteLine($"Sum is: {sum}");

        }

        public static void PrintSumOfNumbers2() {

            int n;

            Console.WriteLine("Enter another number:");
            while (!Int32.TryParse(Console.ReadLine(), out n)) {
                Console.WriteLine("Please enter an integer!");
            }

            int sum = 0;

            for (int i = 1; i <= n; i++) {
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;
            }

            Console.WriteLine($"Sum of 1 to n where n is a multiple of 3 or 5 is {sum}");

        }

        public static void PrintSumOrProduct() {

            int n;

            Console.WriteLine("Enter a another number");

            while (!Int32.TryParse(Console.ReadLine(), out n)) {
                Console.WriteLine("Please enter an integer!");
            }

            Console.WriteLine($"For numbers 1 to {n}...");
            Console.WriteLine($"Enter 1 to calculate the sum or 2 to calculate the product:");

            int selection;

            while ((!Int32.TryParse(Console.ReadLine(), out selection)) && selection != 1 || selection != 2) {
                Console.WriteLine("Invalid selection! Please enter 1 or 2!");
            }

            Console.WriteLine($"You entered {selection}");

            if (selection == 1) {
                int sum = 0;

                for (int i = 1; i <= n; i++) {
                    sum += i;
                    Console.WriteLine($"Sum is: {sum}");
                }
            }
            else {
                int product = 1;
                for (int i = 1; i <= n; i++) {
                    product *= i;
                }
                Console.WriteLine($"Product is: {product}");
            }

        }

    }
}
