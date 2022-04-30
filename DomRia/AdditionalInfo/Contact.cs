using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomRia.AdditionalInfo
{
    class Contact
    {
        public uint Rate { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PhoneNumber { get; set; }

        public Contact(string name,string description,string phoneNumver,uint rate)
        {
            Rate = 0;
            Name = name;
            Description = description;
            PhoneNumber = phoneNumver;
        }
        public override string ToString()
        {
            return $"{Name} {Rate}/10"; 
        }

    }
}
