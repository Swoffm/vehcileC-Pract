using System;

namespace vehicleC

{

    public class Cessna : Vehicle
    {
        public double cost { get; set; }

        public Cessna(double cost, string color, int numOfPeople) : base(color, numOfPeople)
        {
            this.cost = cost;

        }

        public override void Drive()
        {
            Console.WriteLine("run forrest");
        }

        public override void Stop()
        {
            Console.WriteLine("child is stoping");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"Child is turning {direction}!!");

        }
    }

}