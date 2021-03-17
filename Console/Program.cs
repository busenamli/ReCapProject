using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("{0}, {1} TL, {2} model", car.Description, car.DailyPrice, car.ModelYear);
            }

            Console.WriteLine("**********************************");

            foreach (var car in carManager.GetAllByBrandId(1))
            {
                Console.WriteLine("{0}, {1} TL, {2} model", car.Description, car.DailyPrice, car.ModelYear);
            }

            Console.WriteLine("**********************************");

            foreach (var car in carManager.GetAllByColorId(1))
            {
                Console.WriteLine("{0}, {1} TL, {2} model", car.Description, car.DailyPrice, car.ModelYear);
            }

            Console.WriteLine("**********************************");

           
            Console.WriteLine(carManager.GetById(2).Description);
           

            Console.WriteLine("**********************************");

            /*Console.WriteLine("Seçilen araba: {0} ", carManager.GetById(1).Description);

            Console.WriteLine("**********************************");

            foreach (var car in carManager.GetAllByBrandId(1))
            {
                Console.WriteLine("{0}, {1} TL, {2} model", car.Description, car.DailyPrice, car.ModelYear);
            }

            Console.WriteLine("**********************************");

            foreach (var car in carManager.GetAllByColorId(2))
            {
                Console.WriteLine("{0}, {1} TL, {2} model", car.Description, car.DailyPrice, car.ModelYear);
            }*/



            Console.ReadKey();
        }
    }
}
