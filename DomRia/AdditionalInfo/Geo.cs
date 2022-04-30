using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomRia.AdditionalInfo
{
    class Geo
    {
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public Geo(string city):this(city,"")
        {

        }
        public Geo(string city, string street) : this(city, street, "")
        {

        }
        public Geo(string city, string street,string house)
        {
            City = city;
            Street = street;
            House = house;
        }
        public override string ToString()
        {
            return $"{City} {Street} {House}".Trim();
        }
    }
}
