
namespace vehicleC
{
    public interface IElectric
    {
        double BatteryCapacity { get; set; }

        // double CurrentChargePercentage();
        double CurrentChargePercentage { get; set; }

        void ChargeBattery();
    }
}