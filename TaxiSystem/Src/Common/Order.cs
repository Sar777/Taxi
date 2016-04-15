using System;
using TaxiSystem.Database.MySQL;
using TaxiSystem.Object;
using TaxiSystem.Src.Common;
using TaxiSystem.Src.Object;

namespace TaxiSystem.Common
{
    public class Order
    {
        enum DBStatus
        {
            ORDER_NONE          = 0,
            ORDER_NEW           = 1,
            ORDER_CHANGED       = 2,
            ORDER_MAX
        }

        public int Id { get; private set; }
        public Address SAddress { get; set; }
        public Address EAddress { get; set; }
        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }
        public TaxiType Type { get; set; }
        public User Driver { get; set; }
        public User Owner { get; set; }

        // Соятоние заказ для сохранения
        private DBStatus _dbStatus;

        private Order()
        {
            this.Id = 0;
            this.Status = OrderStatus.ORDERING_STATUS_NONE;
            this.Type = TaxiType.TAXI_TYPE_MAX;
            this.Driver = null;
            this.Owner = null;
        }
 
        public Order(int id, User owner, User driver, TaxiType taxiType, OrderStatus status, Address sAddress, Address eAddress, DateTime date)
        {
            this.Id = id;
            this.Owner = owner;
            this.Driver = driver;
            this.SAddress = sAddress;
            this.EAddress = eAddress;
            this.Date = date;
            this.Type = taxiType;
            this.Status = status;
        }

        public Order(User owner, TaxiType taxiType, Address sAddress, Address eAddress)
        {
            this.Id = 0;
            this.Owner = owner;
            this.Driver = null;
            this.SAddress = sAddress;
            this.EAddress = eAddress;
            this.Type = taxiType;
            this.Date = new DateTime();
            this.Status = OrderStatus.ORDERING_STATUS_QUEUE;

            this._dbStatus = DBStatus.ORDER_NEW;
        }

        public void SaveToDb(bool trans = true)
        {
            if (_dbStatus == DBStatus.ORDER_NONE)
                return;

            var mysql = MySQL.Instance();

            if (trans)
                mysql.BeginTransaction();

            var driverId = Driver?.Id ?? 0;
            var ownerId = Owner?.Id ?? 0;

            switch (_dbStatus)
            {
                case DBStatus.ORDER_NEW:
                {
                    int insertId = mysql.PExecute($"INSERT INTO `orders` (`type`, `status`, `date`, `s_address`, `e_address`, `driverId`, `ownerId`) VALUES ('{(int)Type}', '{(int)Status}', '{Time.UnixTimeNow()}', '{SAddress.ToString()}', '{EAddress.ToString()}', '{driverId}', {ownerId})");
                    if (insertId == -1)
                        return;

                    Id = insertId;
                    break;
                }
                case DBStatus.ORDER_CHANGED:
                {
                    mysql.PExecute($"DELETE FROM `orders` WHERE `Id` = {Id}");
                    mysql.PExecute($"INSERT INTO `orders` (`Id`, `type`, `status`, `date`, `s_address`, `e_address`, `driverId`, `ownerId`) VALUES ({Id}, {Type}, {Status}, {Date}, {SAddress.ToString()}, {EAddress.ToString()}, {driverId}, {ownerId})");
                    break;
                }
                default:
                    break;
            }

            _dbStatus = DBStatus.ORDER_NONE;

            if (trans)
                mysql.CommitTransaction();
        }

        public bool IsQueue()
        {
            return Status == OrderStatus.ORDERING_STATUS_QUEUE;
        }

        public bool IsProggress()
        {
            return Status == OrderStatus.ORDERING_STATUS_IN_PROCESS;
        }

        public bool IsValid()
        {
            return Id != 0 && SAddress != null &&
                   EAddress != null && SAddress != EAddress && Owner != null &&
                   Type == TaxiType.TAXI_TYPE_MAX;
        }

        public void Cancel()
        {
            if (Status != OrderStatus.ORDERING_STATUS_QUEUE)
                return;

            Status = OrderStatus.ORDERING_STATUS_CANCELED;
            SaveToDb(true);
        }

        public static string GetOrderStatusString(OrderStatus status)
        {
            switch (status)
            {
                case OrderStatus.ORDERING_STATUS_IN_PROCESS:
                    return "В процессе";
                case OrderStatus.ORDERING_STATUS_NONE:
                    return "Нету";
                case OrderStatus.ORDERING_STATUS_QUEUE:
                    return "В очереди";
                case OrderStatus.ORDERING_STATUS_WAIT:
                    return "Ожидание";
            }

            return "Ошибка";
        }

        public static string GetTaxiType(TaxiType type)
        {
            switch (type)
            {
                case TaxiType.TAXI_TYPE_PASSENGER:
                    return "Пассажирское";
                case TaxiType.TAXI_TYPE_TRUCK:
                    return "Грузовое";
                default:
                    break;
            }

            return "Неизвестно";
        }

        public bool Validate(out string errorText, bool _new = false)
        {
            errorText = "";
            if (Id == 0 && _new)
                errorText = "Неизвестный номер";
            else if (Owner == null)
                errorText = "Неизвестный заказчик";
            else if (Type == TaxiType.TAXI_TYPE_MAX)
                errorText = "Не указан тип такси";
            else if (SAddress == null)
                errorText = "Неизвестный адрес заказ";
            else if (EAddress == null)
                errorText = "Неизвестный адрес назначения";
            else if (SAddress == EAddress)
                errorText = "Адрес заказа и адрес назначения совпадают";

            return errorText.Length == 0;
        }
    }
}
