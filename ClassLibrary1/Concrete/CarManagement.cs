using Business.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManagement : ICarSevice
    {
        InMemoryCarDal _cardal;

        public CarManagement(InMemoryCarDal cardal)
        {
            _cardal = cardal;
        }

       

        public List<Car> GetAll()
        {
            return _cardal.GetAll();
        }
    }
}
