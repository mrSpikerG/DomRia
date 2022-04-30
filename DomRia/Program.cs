using System;

namespace DomRia
{
    class Program
    {
        static void Main(string[] args)
        {
            System sys = new System();
            Action[] act = new Action[5];
            
            act[0] = sys.showAll;
            act[1] = sys.showFilterMoney;
            act[2] = sys.showFilterSeller;
            act[3] = sys.showFilterName;
            act[4] = sys.showSellerInfo;

            do
            {
                Console.WriteLine("1 - Вывод всех продуктов");
                Console.WriteLine("2 - Вывод всех продуктов отсортированых по цене");
                Console.WriteLine("3 - Вывод всех продуктов фильтрованых по риелтору");
                Console.WriteLine("4 - Вывод всех продуктов фильтрованых по названию продукта");
                Console.WriteLine("5 - Вывод информации о риелторе");
                Console.WriteLine("5 - Выход");
                Console.Write("Ваш выбор: ");
                int chose = int.Parse(Console.ReadLine());
                Console.Clear();

                if (chose == 0)
                {
                    break;
                }
                if (chose > 0 && chose < 6)
                {
                    act[chose - 1]?.Invoke();
                }

            } while (true);
        }
    }
}
