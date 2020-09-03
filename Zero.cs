using System;

namespace vehicleC

{
    public class Zero : Vehicle // Electric car
    {
        public double BatteryKWh { get; set; }
        public double cost { get; set; }

        public Zero(double fuelCapacity, double cost, string color, int numOfPeople) : base(color, numOfPeople)
        {
            this.BatteryKWh = fuelCapacity;
            this.cost = cost;


        }

        public override void Drive()
        {
            Console.WriteLine("Zero is a go");
        }

        public override void Stop()
        {
            Console.WriteLine("Zero is stoping");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"Zero is turning {direction}!!");

        }
    }

}