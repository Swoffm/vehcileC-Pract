using System;



namespace vehicleC

{
    public class Tesla : Vehicle // Electric car
    {
        public double BatteryKWh { get; set; }
        public double cost { get; set; }

        public Tesla(double fuelCapacity, double cost, string color, int numOfPeople) : base(color, numOfPeople)
        {
            this.BatteryKWh = fuelCapacity;
            this.cost = cost;


        }

        public override void Drive()
        {
            Console.WriteLine("Tesla is a go");
        }

        public override void Stop()
        {
            Console.WriteLine("Tesla is stoping");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"Tesla is turning {direction}!!");

        }
    }

}