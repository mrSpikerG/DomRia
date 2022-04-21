using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    class System
    {
        public void addProduct()
        {
            if (!Directory.Exists("Products"))
            {
                Directory.CreateDirectory("Products");
            }

            Console.Write("Введите название продукта");
            string title = Console.ReadLine();

            Console.Write("Введите описание продукта");
            string description = Console.ReadLine();

            Console.Write("Введите сколько м³: ");
            uint size = uint.Parse(Console.ReadLine());

            Console.Write("Введите цену продукта: ");
            ulong uah = ulong.Parse(Console.ReadLine());

            Console.Write("Введите расположение продукта: ");
            string adres = Console.ReadLine();

            Console.Write("Введите название риелтора");
            string titleRieltor = Console.ReadLine();

            Console.Write("Введите описание риелтора");
            string descriptionRieltor = Console.ReadLine();

            Console.Write("Введите рейтинг риелтора");
            uint rate = uint.Parse(Console.ReadLine());

            Console.Write("Введите номер риелтора");
            string phoneNumber = Console.ReadLine();

            File.AppendAllText("Products/!DataBase",String.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}",title,description,size,uah,adres,titleRieltor,descriptionRieltor,rate,phoneNumber));
        }

    }
}
