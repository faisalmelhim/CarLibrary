using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CarLibrary
{
    public class Engine
    {
        private int cylinders;
        private double horsepower;

        public int Cylinders
        {
            get { return cylinders; }
            set { cylinders = value; }
        }

        public double Horsepower
        {
            get { return horsepower; }
            set { horsepower = value; }
        }

        public void Start()
        {
            Console.WriteLine("engine starting");
        }

        public void Stop()
        {
            Console.WriteLine("engine stopping");
        }


        public Engine(int cylinders, double horsepower)
        {
            this.cylinders = cylinders;
            this.horsepower = horsepower;

        }

        public Engine()
        {
            cylinders = 0;
            horsepower = 0;
        }
    }
}

