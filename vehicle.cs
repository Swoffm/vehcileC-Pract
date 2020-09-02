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

        public virtual void Drive()
        {
            Console.WriteLine("Vroom");

        }



    }



}