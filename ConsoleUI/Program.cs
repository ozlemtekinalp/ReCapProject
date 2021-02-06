using System;
using Business.Concrete;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    class Program
    {
      

        static void Main(string[] args)
        {
            CarManagement carManagement = new CarManagement(new InMemoryCarDal());

            foreach (var car in carManagement.GetAll())
            {
                Console.WriteLine(car.Description);

            }
            
        }
    }
}