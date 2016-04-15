using System.Text.RegularExpressions;

namespace TaxiSystem.Common
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

        public Address(string address)
        {
            string[] split = address.Split(';');
            this.City = split[0];
            this.Street = split[1];
            this.House = split[2];
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

        public string DbFormat()
        {
            return City + ";" + Street + ";" + House;
        }

        public static bool IsAddressFormat(string address)
        {
            var regex = new Regex(@"([\w]+), ([\w]+), ([\w0-9\\//]+)");
            return regex.IsMatch(address);
        }

        public static Address Parse(string address)
        {
            if (!IsAddressFormat(address))
                return null;

            var regex = new Regex(@"([\w]+), ([\w]+), ([\w0-9\\//]+)");
            var matches = regex.Matches(address);
            return new Address(matches[0].Groups[0].Value, matches[0].Groups[1].Value, matches[0].Groups[2].Value);
        }
    }
}
