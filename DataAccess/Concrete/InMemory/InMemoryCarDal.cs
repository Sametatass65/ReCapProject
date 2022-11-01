using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
            new Car { Id = 1, BrandId = 2, ColorId= 3, DailyPrice= 25000, ModelYear= 2018, Description= "Hayalimdeki araba"},
            new Car { Id = 1, BrandId = 2, ColorId= 3, DailyPrice= 25000, ModelYear= 2018, Description= "İnş alıcam bu arabayı"},
            new Car { Id = 1, BrandId = 2, ColorId= 3, DailyPrice= 25000, ModelYear= 2018, Description= "Bütün Hayallarimi gerçekletiricem"},
            new Car { Id = 1, BrandId = 2, ColorId= 3, DailyPrice= 25000, ModelYear= 2018, Description= "Çok çalışmam lazım çok"}};
        }
        public void Add(Car entity)
        {
            _cars.Add(entity);
        }

        public void Delete(Car entity)
        {

            Car removeToCar = _cars.SingleOrDefault(c => c.Id == entity.Id);
            _cars.Remove(removeToCar);
            //Car removeToCar = null;

            //foreach (var car in _cars) { 
            //    if(car.Id == entity.Id) {
            //        removeToCar = car;
            //}
            //_cars.Remove(removeToCar);

        }

        public Car Get(Expression<Func<Car, bool>> filter)
        { 
            throw new NotImplementedException();  
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        public void Update(Car entity)
        {
            Car updateToCar = _cars.SingleOrDefault(c => c.Id == entity.Id);
            updateToCar.BrandId = entity.BrandId;
            updateToCar.ColorId = entity.ColorId;
            updateToCar.ModelYear = entity.ModelYear;
            updateToCar.Description = entity.Description;

            //Car updateToUpdate = null;
            //foreach (var car in _cars)
            //{
            //    if (car.Id == entity.Id) { 
            //        updateToUpdate.BrandId = car.BrandId;
            //        updateToUpdate.ColorId = car.ColorId;
            //        updateToUpdate.ModelYear = car.ModelYear;
            //        updateToUpdate.Description = car.Description;
            //    }
            //}
        }
    }
}
