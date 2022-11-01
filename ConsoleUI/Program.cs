// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.InMemory;

CarManagers cars = new CarManagers(new InMemoryCarDal());

foreach (var car in cars.GetAll())
{
    Console.WriteLine(car.Description);
}
