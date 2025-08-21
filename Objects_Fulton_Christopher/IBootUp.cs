using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Fulton_Christopher
{
    // The IBootUp interface defines the basic contract for any object
    // that can be powered on or off (like a computer, phone, etc.)
    internal interface IBootUp
    {
        // Property that indicates whether the device is currently powered on (true) or off (false).
        public bool IsOn { get; set; }

        // Method that toggles the device's power state.
        public void PowerOnOff();
    }
}
