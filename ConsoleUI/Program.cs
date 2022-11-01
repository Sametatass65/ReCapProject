// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

CarManagers cars = new CarManagers(new EfCarDal());

foreach (var car in cars.GetAll())
{
    Console.WriteLine(car.Description);
}
