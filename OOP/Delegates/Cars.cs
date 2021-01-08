using System;

namespace OOP.Delegates
{
    class Cars
    {
        public delegate void CarEvent(string message);
        
        private int speed;

        private readonly int maxSpeed;

        private CarEvent carEventHandler;

        public Cars (int maxSpeed)
        {
            this.maxSpeed = maxSpeed;
        }
        public int Speed => speed;

        public void RegisterEventHndler(CarEvent handler)
        {
            this.carEventHandler += handler;
        }

        public void Accelerate (int delta)
        {
            if (this.speed == 0 && delta > 0)
                if (this.carEventHandler != null)
                    this.carEventHandler("INFO: Car started to move.");

            this.speed += delta;

            if(this.speed>=this.maxSpeed)
            {
                this.carEventHandler?.Invoke("WARNING: Max speed is reached");
                this.speed = this.maxSpeed;
            }
            if (this.speed == 0)
                this.carEventHandler?.Invoke("INFO: Car is stopped");
        }

        public void DeregisterCarEventHandler(CarEvent handler)
        {
            this.carEventHandler -= handler;
        }

        public event CarEvent Started
        {
            add { this.carEventHandler += value; }
            remove { this.carEventHandler -= value; }
        }

        public event EventHandler<CarEventArgs> SpeedChanged;

        //Started("INFO: Car started to move");
        //CarEventArgs args = new CarEventArgs(this.speed, this.speed += delta);
        //SpeedChanged(this, args);
    }
}






















