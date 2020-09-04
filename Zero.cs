using System;

namespace vehicleC

{
    public class Zero : Vehicle, IElectric // Electric car
    {
        public double CurrentChargePercentage { get; set; } = 50;

        public double cost { get; set; }
        public double BatteryCapacity { get; set; }



        public Zero(double fuelCapacity, double cost, string color, int numOfPeople) : base(color, numOfPeople)
        {
            this.BatteryCapacity = fuelCapacity;
            this.cost = cost;
        }

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
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