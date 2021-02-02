using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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
                new Car{CarId = 1, CarBrandId = 4 , CarColorId = 3,CarModelYear =2000,DailyPrice = 500 ,CarDescription= "Ford Focus"},
                new Car{CarId = 2, CarBrandId = 4 , CarColorId = 5,CarModelYear =2003,DailyPrice = 850 ,CarDescription= "Ford Fiesta"},
                new Car{CarId = 3, CarBrandId = 2 , CarColorId = 7,CarModelYear =2002,DailyPrice = 730 ,CarDescription= "Toyota Corolla"},
                new Car{CarId = 4, CarBrandId = 2 , CarColorId = 8,CarModelYear =2011,DailyPrice = 450 ,CarDescription= "Toyota Yaris"},
                new Car{CarId = 5, CarBrandId = 1 , CarColorId = 5,CarModelYear =2010,DailyPrice = 1200 ,CarDescription= "Volkswagen Passat"},
                new Car{CarId = 6, CarBrandId = 1 , CarColorId = 2,CarModelYear =2012,DailyPrice = 1500 ,CarDescription= "Volkswagen Tiguan"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
            Console.WriteLine("BİLGİ: {0} siteye eklendi!", car.CarDescription);
        }

        public void Delete(Car car)
        {
            var carToDelete = _cars.FirstOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
            Console.WriteLine("BİLGİ: {0} başarıyla kaldırıldı",car.CarDescription);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetByBrandId(int carBrandId)
        {
            return _cars.Where(c => c.CarBrandId == carBrandId).ToList();
        }

        public void Update(Car car)
        {
            var carToUpdate = _cars.FirstOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.CarBrandId = car.CarBrandId;
            carToUpdate.CarColorId = car.CarColorId;
            carToUpdate.CarModelYear = car.CarModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.CarDescription = car.CarDescription;

        }
    }
}
