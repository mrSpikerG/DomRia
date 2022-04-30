using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomRia.AdditionalInfo;

namespace DomRia
{
    class System
    {
        List<Product> Items = new List<Product>();

        string FullPath;
        public System()
        {

            //Нахождение полного пути
            #region
            string[] temp = Path.GetFullPath("ref").Split("\\");
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] == "DomRia")
                {
                    for (int j = 0; j < i + 1; j++)
                    {
                        FullPath += $"{temp[j]}\\";
                    }
                    break;
                }
            }
            #endregion
            FullPath += "Manager\\bin\\Debug\\net5.0\\Products";

            Console.WriteLine(FullPath);
            getDataBase();
            //showFilterMoney();
            //showFilterSeller();
            //showFilterName();
            showSellerInfo();
            ///showAll();
        }

        public void showAll()
        {
            for (int i = 0; i < Items.Count; i++)
            {
                Console.WriteLine(Items[i]);
            }
        }

        public void showFilterMoney()
        {
            var sortedByMoney = from p in Items orderby p.ProductPrice.UAH select p;
            foreach (var p in sortedByMoney)
            {
                Console.WriteLine($"{p}\n");
            }
        }

        public void showFilterName()
        {
            Console.WriteLine("Введите название жилья которое вас интересует: ");
            string name = Console.ReadLine().ToLower();

            var sortedByName = from p in Items where p.Title.ToLower() == name select p;
            foreach (var p in sortedByName)
            {
                Console.WriteLine($"{p}\n");
            }
        }

        public void showFilterSeller()
        {
            Console.WriteLine("Введите риелтора который вас интересует: ");
            string sellerName = Console.ReadLine();

            var sortedBySeller = from p in Items where p.Seller.Name == sellerName select p;
            foreach (var p in sortedBySeller)
            {
                Console.WriteLine($"{p}\n");
            }
        }

        public void showSellerInfo()
        {
            Console.WriteLine("Введите риелтора который вас интересует: ");
            string sellerName = Console.ReadLine();

            var Seller = from p in Items where p.Seller.Name == sellerName select p;

            foreach (var s in Seller)
            {

                Console.WriteLine($"{s.Seller}\n{s.Seller.Description}\nТелефон:{s.Seller.PhoneNumber}");
                break;
            }

        }

        private void getDataBase()
        {
            string txt = File.ReadAllText($"{FullPath}\\!DataBase.txt");
            string[] Houses = txt.Split("\n");
            for (int i = 0; i < Houses.Length; i++)
            {
                string[] TEMP = Houses[i].Split("|");

                if (!Convert.ToBoolean(TEMP[9]))
                {
                    Items.Add(new Product(new Contact(TEMP[5], TEMP[6], TEMP[8], Convert.ToUInt32(TEMP[7])), new Geo(TEMP[4]), new Price(Convert.ToUInt64(TEMP[3])), TEMP[0], TEMP[1], Convert.ToUInt32(TEMP[2])));
                }
            }
        }
    }
}
