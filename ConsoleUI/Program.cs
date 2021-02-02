using Business.Concrete;
using DataAccess.Concrete;
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
                Console.WriteLine(car.Description+" : "+car.DailyPrice);
            }
            Console.WriteLine();
            InMemoryCarDal carDal = new InMemoryCarDal();
            carDal.Add(new Entities.Concrete.Car { Id =7,BrandId=4,ColorId=4,DailyPrice=25000,ModelYear=1998,Description="Tofaş Şahin Kırmızı"});
            carDal.Update(new Entities.Concrete.Car { Id = 2, BrandId = 1, DailyPrice = 300000, ModelYear = 2018, ColorId = 2, Description = "Volkswagen Golf Beyaz" });
            foreach (var updatedCar in carDal.GetAll())
            {
                Console.WriteLine(updatedCar.Description+" : "+updatedCar.DailyPrice);
            }


        }
    }
}
