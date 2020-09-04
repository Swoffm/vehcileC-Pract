using System.Collections.Generic;
using System;
namespace vehicleC

{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero(550, 5000, "Red", 2);
            Zero fx = new Zero(400, 2500, "Blue", 4);
            Tesla modelS = new Tesla(234, 52344, "Silver", 6);

            List<IElectric> electricVehicles = new List<IElectric>() {
                fx, fxs, modelS
              };

            Console.WriteLine("Electric Vehicles");
            foreach (IElectric ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            foreach (IElectric ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach (IElectric ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            /***********************************************/

            Ram ram = new Ram(500, 25000, "Green", 6);
            Cessna cessna150 = new Cessna(2500, "Blue", 7);

            List<IGas> gasVehicles = new List<IGas>() {
                ram, cessna150
              };

            Console.WriteLine("Gas Vehicles");
            foreach (IGas gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }

            foreach (IGas gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach (IGas gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }
        }
    }
}