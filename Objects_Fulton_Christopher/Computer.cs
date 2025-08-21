using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Fulton_Christopher
{
    // The Computer class represents a computer device that can be powered on or off.
    // It implements the IBootUp interface, meaning it must define an IsOn property
    // and the PowerOnOff() method.
    internal class Computer : IBootUp
    {
        // Tracks whether the computer is currently powered on (true) or off (false).
        public bool IsOn { get; set; }

        // The manufacturer of the computer (e.g., Apple, Dell).
        public string Brand { get; set; }

        // The type of computer (e.g., Laptop, Desktop, All-in-One).
        public string Type { get; set; }

        // Constructor to initialize a computer with brand, type, and power state.
        public Computer(string brand, string type, bool isOn)
        {
            Brand = brand;
            Type = type;
            IsOn = isOn;
        }

        // Toggles the computer's power state between on and off.
        // Displays a message to the console depending on the new state.
        public void PowerOnOff()
        {
            IsOn = !IsOn; // Flip the power state (true becomes false, false becomes true)

            if (IsOn == true)
            {
                Console.WriteLine("The computer is booting up!");
            }
            else
            {
                Console.WriteLine("The computer is shutting down!");
            }
        }

        // Overrides the default ToString() method.
        // Provides a descriptive string about the computer's brand, type, and power state.
        public override string ToString()
        {
            return $"The computer is made by {Brand} and is a(n) {Type} computer, it is on: {IsOn}!";
        }
    }
}
