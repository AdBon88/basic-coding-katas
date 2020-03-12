using System;
namespace basic_coding_katas {
    public class NumberPrinter {
        const int NumberOfMainMenuOptions = 3;

        public void Start() {

            DisplayOptions();
  
            switch( ReadSelectedOption(NumberOfMainMenuOptions)){
                case 1:
                    PrintSumOfRange();
                    break;
                case 2:
                    PrintSumOfMultiplesOfThreeOrFive();
                    break;
                case 3:
                    PrintProductOfRange();
                    break;
            }
        }

        private void DisplayOptions() {
            Console.WriteLine("Select option:");
            Console.WriteLine("1. Print the sum of all numbers from 1 to n");
            Console.WriteLine("2. Print the sum of all multiples of 3 or 5 between 1 and n");
            Console.WriteLine("3. Print the product of all numbers from 1 to n");
        }

        private int ReadSelectedOption(int numberOfOptions) {
            int selectedOption;

            while ((!Int32.TryParse(Console.ReadLine(), out selectedOption)) || selectedOption < 1 || selectedOption > numberOfOptions) {
                Console.WriteLine($"Invalid selection! Please enter a number from 1 to {numberOfOptions}");
            }

            return selectedOption;
        }

        public void PrintSumOfRange() {

            int n = ReadIntegerInput();
            int sum = 0;

            for (int i = 1; i <= n; i++) {
                sum += i;
            }

            Console.WriteLine($"Sum is: {sum}");

        }

        private void PrintSumOfMultiplesOfThreeOrFive() {

            int n = ReadIntegerInput();
            int sum = 0;

            for (int i = 1; i <= n; i++) {
                if ( i % 3 == 0 || i % 5 == 0)
                    sum += i;
            }

            Console.WriteLine($"Sum of multiples of 3 or 5 in range is: {sum}");

        }

        private void PrintProductOfRange() {

            int n = ReadIntegerInput();

            int product = 1;
            for (int i = 1; i <= n; i++) {
                product *= i;
            }
            Console.WriteLine($"Product is: {product}");
            
        }

        private int ReadIntegerInput() {

            int n;
            Console.WriteLine("Enter the maximum number:");
            while (!Int32.TryParse(Console.ReadLine(), out n)) {
                Console.WriteLine("Please Enter an integer!");
            }

            return n;
        }

    }
}
