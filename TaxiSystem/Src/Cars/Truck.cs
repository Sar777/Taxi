using TaxiSystem.Src.Common;
using TaxiSystem.Src.Object;

namespace TaxiSystem.Cars
{
    public class Truck : Car
    {
        private Truck() : base()
        {
            this.CarTypeId = TaxiType.TAXI_TYPE_TRUCK;
        }
    }
}
