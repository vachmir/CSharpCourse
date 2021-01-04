using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Inheritance
{
    class Radio
    {
        public string ChannelName { get; set; }
        public double Frequency { get; set; }

        public void PowerOn()
        {
            // Code to power on the radio and tune to channel
        }

        public void Mute()
        { }

        public void Unmute()
        { }
    }
}
