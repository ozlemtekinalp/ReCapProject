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
        ıCardal _cardal;

        public CarManagement(ICarDal cardal)
        {
            _cardal = cardal;
        }

       

        public List<Car> GetAll()
        {
            return _cardal.GetAll();
        }
    }
}
