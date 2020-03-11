using System;
namespace basic_coding_katas {
    public class NameGreeter {

        public static void Greet() {
            string name;
            Console.WriteLine("Please enter your name:");
            name = Console.ReadLine();
            Console.WriteLine($"Hello {name}!");
        }
    }
}
