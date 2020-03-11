using System;
namespace basic_coding_katas {
    public class SpecificNameGreeter {

        public static void Greet() {
            string name;
            Console.WriteLine("Please enter your name:");
            name = Console.ReadLine();
            if (name == "Alice" || name == "Bob")
                Console.WriteLine($"Hello {name}!");
        }
    }
}
