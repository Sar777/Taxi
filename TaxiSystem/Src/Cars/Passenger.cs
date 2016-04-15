using TaxiSystem.Src.Common;
using TaxiSystem.Src.Object;

namespace TaxiSystem.Cars
{
    public class Passenger : Car
    {
        public int Passengers { get; private set; }

        private Passenger() : base()
        {
            this.Passengers = 0;
            this.CarTypeId = TaxiType.TAXI_TYPE_PASSENGER;
        }
    }
}