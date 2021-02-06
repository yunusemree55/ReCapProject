using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            //Database'deki veriler
            _cars = new List<Car>
            {
                new Car{Id = 1, BrandId = 4 , ColorId = 3,ModelYear =2000,DailyPrice = 500 ,Description= "Ford Focus"},
                new Car{Id = 2, BrandId = 4 , ColorId = 5,ModelYear =2003,DailyPrice = 850 ,Description= "Ford Fiesta"},
                new Car{Id = 3, BrandId = 2 , ColorId = 7,ModelYear =2002,DailyPrice = 730 ,Description= "Toyota Corolla"},
                new Car{Id = 4, BrandId = 2 , ColorId = 8,ModelYear =2011,DailyPrice = 450 ,Description= "Toyota Yaris"},
                new Car{Id = 5, BrandId = 1 , ColorId = 5,ModelYear =2010,DailyPrice = 1200 ,Description= "Volkswagen Passat"},
                new Car{Id = 6, BrandId = 1 , ColorId = 2,ModelYear =2012,DailyPrice = 1500 ,Description= "Volkswagen Tiguan"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
            Console.WriteLine("BİLGİ: {0} siteye eklendi!", car.Description);
        }

        public void Delete(Car car)
        {
            var carToDelete = _cars.FirstOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
            Console.WriteLine("BİLGİ: {0} başarıyla kaldırıldı",car.Description);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }


        public void Update(Car car)
        {
            var carToUpdate = _cars.FirstOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }
    }
}
