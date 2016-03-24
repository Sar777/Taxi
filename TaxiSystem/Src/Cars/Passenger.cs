
using TaxiSystem.Src.Object;
using TaxiSystem.Src.Common;

namespace TaxiSystem.Src.Cars
{
    class Passenger : Car
    {
        public PassengerCarType BodyType { get; private set; }
        public int Passengers { get; private set; }

        public Passenger() : base()
        {
            this.Passengers = 0;
            this.CarTypeId = CarType.CAR_TYPE_PASSENGER;
            this.BodyType = PassengerCarType.PASSENGER_CAR_DEFAULT;
        }
    }
}
