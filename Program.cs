using System;

namespace vehicleC
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle Tesla = new Vehicle("black", 4);

            Cessna Steve = new Cessna(100, "green", 5);

            Tesla.Drive();
            Steve.Drive();
            Tesla.Stop();
            Tesla.Turn("left");
            Steve.Stop();
            Steve.Turn("right");




        }
    }
}
