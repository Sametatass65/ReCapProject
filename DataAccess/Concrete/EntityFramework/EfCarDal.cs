using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRespositoryBase<Car, ReCapProjectContext>, ICarDal
    {
        public List<CarDto> getCarDto()
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.Id
                             join cl in context.Colors on c.ColorId equals cl.Id
                             select new CarDto { BrandName = b.Name, CarName = c.CarName, ColorName = cl.Name, DailyPrice = c.DailyPrice };
                return (result.ToList());
            }
        }
    }
}
