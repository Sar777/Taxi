using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiSystem.Src.Common
{
    // Типы автомобилей
    public enum CarType
    {
        CAR_TYPE_NONE                   = 0,
        CAR_TYPE_PASSENGER              = 1,
        CAR_TYPE_TRUCK                  = 2,
    }

    // Типы легковых автомобилей
    public enum PassengerCarType
    {
        PASSENGER_CAR_DEFAULT          = 0,
        PASSENGER_CAR_HATCHBACK        = 1,
        PASSENGER_CAR_ESTATE           = 2,
        PASSENGER_CAR_MINIBUS          = 3
    }

    // Состояние заказа
    public enum OrderStatus
    {
        ORDERING_STATUS_NONE            = 0,
        ORDERING_STATUS_QUEUE           = 1,
        ORDERING_STATUS_WAITE           = 2,
        ORDERING_STATUS_IN_PROCESS      = 3,
        ORDERING_STATUS_DONE            = 4
    }

    // Типы пользователей
    public enum UserType
    {
        USER_TYPE_UNKNOWN               = 0,
        USER_TYPE_CLIENT                = 1,
        USER_TYPE_MANAGER               = 2,
        USER_TYPE_DRIVER                = 3,
    }

    // Состояния водителя
    public enum DriverStatus
    {
        DRIVER_STATUS_NONE              = 0,
        DRIVER_STATUS_WAITE             = 1,
        DRIVER_STATUS_IN_PROGRESS       = 2,
    }
}
