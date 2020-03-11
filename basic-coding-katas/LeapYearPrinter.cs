using System;
namespace basic_coding_katas {
    public class LeapYearPrinter {

        public static void Print() {

            int currentYear = DateTime.Now.Year;
            int leapYearCount = 0;

            Console.WriteLine("The next 20 leap years are:");

            do {
                if (currentYear % 400 == 0 || (currentYear % 4 == 0 && currentYear % 100 != 0)) {
                    Console.WriteLine(currentYear);
                    leapYearCount++;
                }
                currentYear++;

            } while (leapYearCount < 20);
            }
        }
    }
