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
        public float Rate { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PhoneNumber { get; set; }

        public System(string name, string description, string phoneNumver, float Rate)
        {
            Rate = 0;
            Name = name;
            Description = description;
            PhoneNumber = phoneNumver;
        }
        public void addProduct()
        {
            if (!Directory.Exists("Products"))
            {
                Directory.CreateDirectory("Products");
            }

            Console.Write("Введите название продукта: ");
            string title = Console.ReadLine();

            Console.Write("Введите описание продукта: ");
            string description = Console.ReadLine();

            Console.Write("Введите сколько м³: ");
            uint size = uint.Parse(Console.ReadLine());

            Console.Write("Введите цену продукта: ");
            ulong uah = ulong.Parse(Console.ReadLine());

            Console.Write("Введите расположение продукта: ");
            string adres = Console.ReadLine();

            File.AppendAllText("Products/!DataBase.txt", String.Format("\n{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|false", title, description, size, uah, adres, Name, Description, Rate, PhoneNumber));

            if (!Directory.Exists($"Products/{Name}"))
            {
                Directory.CreateDirectory($"Products/{Name}");
            }
            File.WriteAllText($"Products/{Name}/{title}-{size}.txt", String.Format("{0}|{1}|{2}|{3}|{4}", title, description, size, uah, adres));
        }

        public void removeProduct()
        {
            Console.Write("Введите название продукта");
            string title = Console.ReadLine();

            string database = File.ReadAllText("Products/!DataBase.txt");
            string[] products = database.Split("\n");


            File.WriteAllText("Products/!DataBase.txt", "");
            string chose;
            for (int i = 0; i < products.Length; i++)
            {
                chose = "Нет";
                string[] temp = products[i].Split("|");
                if (temp[0] == title && temp[5] == Name)
                {
                    Console.WriteLine($"{temp[0]}, {temp[2]}, {temp[4]}");
                    Console.WriteLine("Желаете удалить данный продукт? ");
                    Console.Write("Ваш выбор(Да/Нет): ");
                    chose = Console.ReadLine();

                }
                if (chose == "Нет")
                {
                    File.AppendAllText("Products/!DataBase.txt", String.Join("|", temp));
                }
                else
                {
                    File.Delete($"Products/{Name}/{temp[0]}-{temp[2]}.txt");

                }
            }
        }

        public void archiveProduct()
        {
            Console.Write("Введите название продукта: ");
            string title = Console.ReadLine();

            string database = File.ReadAllText("Products/!DataBase.txt");
            string[] products = database.Split("\n");


            File.WriteAllText("Products/!DataBase.txt", "");
            string chose;
            for (int i = 0; i < products.Length; i++)
            {
                chose = "Нет";
                string[] temp = products[i].Split("|");
                if (temp[0] == title && temp[5] == Name)
                {
                    Console.WriteLine($"{temp[0]}, {temp[2]}, {temp[4]}");
                    Console.WriteLine("Желаете заархивировать данный продукт? ");
                    Console.Write("Ваш выбор(Да/Нет): ");
                    chose = Console.ReadLine();

                }
                if (chose == "Да")
                {
                    temp[9] = "true";
                    File.Move($"Products/{Name}/{temp[0]}-{temp[2]}.txt", ($"Products/{Name}/{temp[0]}-{temp[2]}-archived.txt"));
                }
                File.AppendAllText("Products/!DataBase.txt", String.Join("|", temp));
            }
        }
        public void dearchiveProduct()
        {
            Console.Write("Введите название продукта: ");
            string title = Console.ReadLine();

            string database = File.ReadAllText("Products/!DataBase.txt");
            string[] products = database.Split("\n");


            File.WriteAllText("Products/!DataBase.txt", "");
            string chose;
            for (int i = 0; i < products.Length; i++)
            {
                chose = "Нет";
                string[] temp = products[i].Split("|");
                if (temp[0] == title && temp[5] == Name)
                {
                    Console.WriteLine($"{temp[0]}, {temp[2]}, {temp[4]}");
                    Console.WriteLine("Желаете разархивировать данный продукт? ");
                    Console.Write("Ваш выбор(Да/Нет): ");
                    chose = Console.ReadLine();

                }
                if (chose == "Да")
                {
                    temp[9] = "false";
                    if (File.Exists($"Products/{Name}/{temp[0]}-{temp[2]}-archived.txt"))
                    {
                        File.Move($"Products/{Name}/{temp[0]}-{temp[2]}-archived.txt", $"Products/{Name}/{temp[0]}-{temp[2]}.txt");
                    }
                }
                File.AppendAllText("Products/!DataBase.txt", String.Join("|", temp));
            }
        }
    }
}
