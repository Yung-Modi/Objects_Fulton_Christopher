namespace Objects_Fulton_Christopher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new Computer object with brand, type, and power state.
            Computer myComputer = new Computer("Apple", "All-in-One", true);

            // Store the computer in an interface reference (IBootUp).
            IBootUp myBootUp = myComputer;

            // Compare the Computer object to the interface reference using Equals().
            Console.WriteLine(myComputer.Equals(myBootUp));

            // Create another Computer object with the same values as the first one.
            Computer myOtherComputer = new Computer("Apple", "All-in-One", true);

            // Compare two Computer objects using Equals().
            Console.WriteLine(myComputer.Equals(myOtherComputer));

            // Store the string version (ToString result) of the computer in myString.
            string myString = myComputer.ToString();

            // Assign the same string reference to another variable.
            string myOtherString = myString;

            // Change myString to a completely different string.
            myString = "Hi!";

            // Output both strings (they will differ now because strings are immutable).
            Console.WriteLine(myString);       // Prints "Hi!"
            Console.WriteLine(myOtherString);  // Still holds the original computer's ToString() value

            // Compare the updated myString to the ToString() of both computer objects.
            Console.WriteLine(myString == myComputer.ToString());
            Console.WriteLine(myString == myOtherComputer.ToString());

            // Get the runtime type of the objects.
            Console.WriteLine(myComputer.GetType()); // Should print the Computer type
            Console.WriteLine(myBootUp.GetType());   // Still the Computer type, not just IBootUp

            // Call a method to toggle the power state of myOtherComputer.
            myOtherComputer.PowerOnOff();

            // Compare myString to the updated myOtherComputer.ToString().
            Console.WriteLine(myString == myOtherComputer.ToString());

            // Print myString and myOtherComputer.ToString() for clarity.
            Console.WriteLine(myString);
            Console.WriteLine(myOtherComputer.ToString());

            // Check if myString contains the character 'i'.
            Console.WriteLine(myString.Contains('i'));

            // Convert myString to uppercase and print it.
            Console.WriteLine(myString.ToUpper());
        }
    }
}

