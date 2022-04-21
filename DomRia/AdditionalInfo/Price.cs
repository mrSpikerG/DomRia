using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomRia.AdditionalInfo
{
    class Price
    {
        public ulong UAH { get; set; }
        public ulong USD { get; set; }

        public Price(ulong uah,ulong usd)
        {
            UAH = uah;
            USD = usd;
        }
        public Price(ulong uah)
        {
            UAH = uah;
            USD = uah * 29;
        }
    }
}
