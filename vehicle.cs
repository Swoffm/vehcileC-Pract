using System;

namespace vehicleC
{

    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public Vehicle(string color, int numOfPeople)
        {
            this.MainColor = color;
            this.MaximumOccupancy = numOfPeople;

        }

        public virtual void Turn(string direction)
        {
            Console.WriteLine($"Parent is turning {direction}!!");

        }

        public virtual void Stop()
        {
            Console.WriteLine("Parent is stoping");

        }

        public virtual void Drive()
        {
            Console.WriteLine("Vroom");

        }



    }



}