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
            _cars = new List<Car>
            {
                new Car { Id = 1, BrandId = 1, ModelYear = "2018", DailyPrice = 300, Description = "Polo" },
                new Car { Id = 2, BrandId = 1, ModelYear = "2008", DailyPrice = 300, Description = "Golf" },
                new Car { Id = 3, BrandId = 2, ModelYear = "2020", DailyPrice = 300, Description = "BMW" }

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car cartoDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
            _cars.Remove(cartoDelete);

        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return  _cars.Where(p => p.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car cartoUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            cartoUpdate.Id = car.Id;
            cartoUpdate.BrandId = car.BrandId;
            cartoUpdate.Description = car.Description;
            cartoUpdate.DailyPrice = car.DailyPrice;
        }
    }
}
