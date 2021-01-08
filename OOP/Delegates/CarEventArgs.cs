using System;

namespace OOP.Delegates
{
    class CarEventArgs : EventArgs
    {
        public CarEventArgs(int oldSpeed, int newSpeed)
        {
            this.OldSpeed = oldSpeed;
            this.NewSpeed = newSpeed;
        }
        public int OldSpeed { get; private set; }
        public int NewSpeed { get; private set; }
    }
}
