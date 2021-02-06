using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleeUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car1 = new Car() { BrandId = 1, ColorId = 2, DailyPrice = 900, Description = "Ford", ModelYear = 2009 };

            carManager.Add(car1);

            


        }
    }
}
