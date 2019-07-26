using System;

namespace SmartRefrigerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Refrigerator _refrigerator = new Refrigerator();
            Vegetable tomato = new Tomato();
            Vegetable cabbage = new Cabbage();
            _refrigerator.AddVegetable(tomato, 9);
            _refrigerator.AddVegetable(cabbage, 6);
            _refrigerator.SetMinimumQuantity(tomato, 5);
            _refrigerator.SetMinimumQuantity(cabbage, 4);
            Console.WriteLine(_refrigerator.TakeOutVegetable(cabbage, 3));
        }
    }
}
