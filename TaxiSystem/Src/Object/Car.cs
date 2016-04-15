
using TaxiSystem.Database.MySQL;
using TaxiSystem.Src.Common;

namespace TaxiSystem.Src.Object
{
    public class Car
    {
        public int ID { get; private set; }
        public string Model { get; set; }
        public string Number { get; set; }
        public string Color { get; set; }

        public TaxiType CarTypeId { get; protected set; }

        protected Car()
        {
            this.Model = "Unknown";
            this.Number = "Unknown";
            this.Color = "Unknown";
            this.CarTypeId = TaxiType.TAXI_TYPE_MAX;
        }

        public void SaveToDB(bool trans = true)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 
        {
            MySQL mysql = MySQL.Instance();

            if (trans)
                mysql.BeginTransaction();

            mysql.PExecute(string.Format("DELETE FROM `cars` WHERE `Id` = {0}", ID));
            mysql.PExecute(string.Format("INSERT INTO `cars` (`Id`, `model`, `number`, `color`, `type`) VALUES ({0}, {1}, {2}, {3}, {4})", ID, Model, Number, Color, CarTypeId));

            if (trans)
                mysql.CommitTransaction();
        }
    }
}
