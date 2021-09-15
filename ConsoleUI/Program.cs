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

            foreach (var car in carManager.GetCarsByBrandId(3))
            {
                Console.WriteLine(car.Description + " : " + car.BrandId);
            }

            foreach (var car in carManager.GetCarsByUnitPrice(10000, 20000))
            {
                Console.WriteLine(car.Description + " : " + car.BrandId);
            }
        }
    }
}
