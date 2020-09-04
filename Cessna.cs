using System;

namespace vehicleC

{

    public class Cessna : Vehicle, IGas
    {
        public double cost { get; set; }


        // igas 
        public double CurrentTankPercentage { get; set; } = 100;
        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }

        //-----------------------------


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