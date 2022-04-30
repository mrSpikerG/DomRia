using DomRia.AdditionalInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomRia
{
    class Product
    {
        public Contact Seller { get; set; }
        public Geo GEO { get; set; }
        public Price ProductPrice { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public uint Size { get; set; }

        public Product(Contact seller,Geo geo,Price price,string title,string desciption,uint size)
        {
            Seller = seller;
            GEO = geo;
            ProductPrice = price;
            Title = title;
            Description = desciption;
            Size = size;
        }

        public override string ToString()
        {
            return String.Format("Название: {0}\t\tОписание:{1}\t\t{2}м\nРиелтор: {3}\nАдресс: {4}\tЦена: {5}", Title,Description,Size,Seller,GEO,ProductPrice);
        }
    }
}
