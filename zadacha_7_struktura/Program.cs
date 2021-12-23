using System;

namespace zadacha_6._2_biblioteka
{
    class Program
    {
        struct Tovar
        {
            public string name;
            public DateTime pr;
            public DateTime srok;
            public int cost;
            public int ser;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите какое количество товара необходимо записать: ");
            int a = int.Parse(Console.ReadLine());
            Tovar[] tovars = new Tovar[a];
            for (int i = 0; i < tovars.Length; i++)
            {
                Console.Write("Введите название товара: ");
                tovars[i].name = Console.ReadLine();
                Console.WriteLine("Введите дату производства:");
                Console.WriteLine("Год");
                int god = int.Parse(Console.ReadLine());
                Console.WriteLine("День");
                int day = int.Parse(Console.ReadLine());
                Console.WriteLine("Месяц");
                int mon = int.Parse(Console.ReadLine());
                tovars[i].pr = new DateTime(god, mon, day);
                Console.WriteLine("Введите срок годности:");
                Console.WriteLine("Год");
                int god1 = int.Parse(Console.ReadLine());
                Console.WriteLine("День");
                int day1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Месяц");
                int mon1 = int.Parse(Console.ReadLine());
                tovars[i].srok = new DateTime(god1, mon1, day1);
                Console.Write("Введите цену товара:");
                tovars[i].cost = int.Parse(Console.ReadLine());
                Console.Write("Введите номер серии товара:");
                tovars[i].ser = int.Parse(Console.ReadLine());
                tovars[i].pr.AddDays(5);
            }
            foreach (Tovar item in tovars)
            {
                {
                    Console.WriteLine(item.name + ", " + item.pr + ", " + item.srok + ", " + item.cost + ", " + item.ser);
                }
            }
        }
    }
}
