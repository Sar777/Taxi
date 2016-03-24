
using TaxiSystem.Src.Common;

namespace TaxiSystem.Src.Object
{
    public class Car
    {
        public string Model { get; set; }
        public string Number { get; set; }
        public string Color { get; set; }

        public CarType CarTypeId { get; protected set; }

        public Car()
        {
            this.Model = "Unknown";
            this.Number = "Unknown";
            this.Color = "Unknown";
            this.CarTypeId = CarType.CAR_TYPE_NONE;
        }
    }
}
