using System;



namespace vehicleC

{
    public class Ram : Vehicle // Gas powered truck
    {
        public double FuelCapacity { get; set; }
        public double cost { get; set; }

        public Ram(double fuelCapacity, double cost, string color, int numOfPeople) : base(color, numOfPeople)
        {
            this.FuelCapacity = fuelCapacity;
            this.cost = cost;


        }

        public override void Drive()
        {
            Console.WriteLine("Ram is a go");
        }

        public override void Stop()
        {
            Console.WriteLine("Ram is stoping");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"Ram is turning {direction}!!");

        }
    }

}