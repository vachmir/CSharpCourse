using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Inheritance
{
    class Car
    {
        private readonly uint maxSpeed;
        private uint currentSpeed;

        public Car()
        {
            this.maxSpeed = 120; // կմ/ժ
        }

        public uint Speed
        {
            get => this.currentSpeed;
            set
            {
                this.currentSpeed = value > this.maxSpeed ? this.maxSpeed : value;
            }
        }

        protected Radio radio { get; set; } = new Radio();

        public void Ignite()
        {
            // Code to ignite the car

            radio = new Radio();
            radio.ChannelName = "Ռադիո Ջան";
            radio.PowerOn();
        }
    }
}
