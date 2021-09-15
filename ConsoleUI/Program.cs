using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
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
                Console.WriteLine(car.Description);
            }
            Console.WriteLine("-------------------------------");
            foreach (var car in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine(car.Description + " : " + car.BrandId);
            }
            Console.WriteLine("------------------------------------");
            foreach (var car in carManager.GetCarsByUnitPrice(100, 20000))
            {
                Console.WriteLine(car.Description + " : " + car.BrandId);
            }
        }
    }
}
