using System;

namespace MyDictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> cars = new MyDictionary<string, string>();

            cars.Add("Opel", "Corsa");
            Console.WriteLine(cars.Length);
            cars.Add("Volkswagen", "Golf");
            Console.WriteLine(cars.Length);
            cars.Add("Tesla", "Model S");
            Console.WriteLine(cars.Length);
            cars.Add("Mercedes", "C180");
            Console.WriteLine(cars.Length);
            
            

        }
    }
}
