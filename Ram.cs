using System;



namespace vehicleC

{
    public class Ram : Vehicle, IGas // Gas powered truck
    {
        public double FuelCapacity { get; set; }
        public double cost { get; set; }

        // IGas 
        public double CurrentTankPercentage { get; set; } = 25;

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }
        //--------------------

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