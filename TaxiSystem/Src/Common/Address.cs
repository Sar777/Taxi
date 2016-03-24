using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiSystem.Src
{
    public class Address
    {
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set;  }

        public Address()
        {
            this.City = "Unknown";
            this.Street = "Unknown";
            this.House = "Unknown";
        }

        public Address(string city, string street, string house)
        {
            this.City = city;
            this.Street = street;
            this.House = house;
        }

        public override string ToString()
        {
            return City + ", " + Street + ", " + House;
        }
    }
}
