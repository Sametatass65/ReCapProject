using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);
            return new SuccessResult(Message.SuccessAdded);
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult(Message.SuccessDeleted);
        }

        public IDataResult<Brand> Get(int Id)
        {
            return new DataSuccessResult<Brand>(_brandDal.Get(p => p.Id == Id), Message.SuccessGet);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new DataSuccessResult<List<Brand>>(_brandDal.GetAll(), Message.SuccessGet);
        }

        public IResult Update(Brand brand)
        {
            _brandDal.Update(brand);
            return new SuccessResult(Message.SuccessUpdated);
        }
    }
}
