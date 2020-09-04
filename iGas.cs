
namespace vehicleC
{
    public interface IGas
    {
        double CurrentTankPercentage { get; set; }

        void RefuelTank();
    }
}