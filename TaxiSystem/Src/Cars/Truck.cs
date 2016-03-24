
using TaxiSystem.Src.Object;
using TaxiSystem.Src.Common;

namespace TaxiSystem.Src.Cars
{
    public class Truck : Car
    {
        public Truck() : base()
        {
            this.CarTypeId = CarType.CAR_TYPE_TRUCK;
        }
    }
}
