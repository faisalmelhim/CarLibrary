using System;
using System.Collections.Generic;
using System.Text;

namespace CarLibrary
{
    public class Car
    {
        public string Make
        {
            get;
            set;
        }
        public string Model
        {
            get;
            set;
        }
        public int Year
        {
            get;
            set;
        }

        public Engine engine
        {
            get;
            set;
        }

        public Car(string make, string model, int year, Engine engine)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.engine = engine;
        }

        public Car()
        {
            Make = "Unkown";
            Model = "Unkown";
            Year = 0;
            this.engine = new Engine();

        }

        public void Drive()
        {
            engine.Start();
            Console.WriteLine("driving started");
        }

        public void Stop()
        {
            engine.Stop();
            Console.WriteLine("driving stopped");
        }

    }
}
