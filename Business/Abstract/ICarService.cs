using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetCarByBrandId(int brandId);
        List<Car> GetCarByColorId(int colorId);
        void Add(Car car);  
        void Update(Car car);
        void Delete(Car car);

    }
}
