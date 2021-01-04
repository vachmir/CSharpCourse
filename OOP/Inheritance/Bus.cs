using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Inheritance
{
    class Bus : Car
    {
        public void StopAtBusStop()
        {
            // Code to stop the bus

            this.radio.Mute();
        }
    }
}
