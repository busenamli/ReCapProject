using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("{0}, {1} TL, {2} model", car.Description, car.DailyPrice, car.ModelYear);
            }

            Console.ReadKey();
        }
    }
}
