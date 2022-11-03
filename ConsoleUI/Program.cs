// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

CarManager cars = new CarManager(new EfCarDal());

foreach (var car in cars.GetAll().Data)
{
    Console.WriteLine(car.Description);
}
Console.WriteLine(cars.GetAll().message);
