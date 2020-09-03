using System;

namespace vehicleC
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle Car = new Vehicle("black", 4);

            Cessna Steve = new Cessna(100, "green", 5);

            Zero greenBeast = new Zero(50, 1000, "green", 1);
            Tesla powerMachine = new Tesla(520, 1000, "green", 12);
            Ram goat = new Ram(5230, 1000, "blue", 11);


            greenBeast.Drive();
            powerMachine.Drive();
            powerMachine.Drive();
            Car.Drive();
            Steve.Drive();
            Car.Stop();
            greenBeast.Stop();
            powerMachine.Stop();
            goat.Stop();
            Car.Turn("left");
            Steve.Stop();
            Steve.Turn("right");




        }
    }
}
