using Business.Abstract;
using Business.BusinessAspect.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspect.Autofac.Caching;
using Core.Aspect.Autofac.Validaiton;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        //[ValidationAspect(typeof(CarValidator))]
        [SecuredOperation("adim,add")]
       
        public IResult Add(Car car)
        {
            //var context = new ValidationContext<Car>(car);//validation kuraqlım var diyorsun
            //CarValidator validationRules = new CarValidator();// instance oluşturyorsun 
            //var result = validationRules.Validate(context);// istance bu ve iznimde bu diyorsun 
            //if (!result.IsValid) {
            //    throw new ValidationException(result.Errors);
            //}
            //ValidationTool.Validdate(new CarValidator(), car);
            _carDal.Add(car);            
            return new SuccessResult(Message.SuccessAdded);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Message.SuccessDeleted);
        }
        [CacheAspect]
        public IDataResult<List<Car>> GetAll()
        {
            return new DataSuccessResult<List<Car>>(_carDal.GetAll(),Message.SuccessGet);
        }

        public IDataResult<List<CarDto>> GetAllCarDto()
        {
            return new DataSuccessResult<List<CarDto>>(_carDal.getCarDto(), Message.SuccessGet);
        }

        public IDataResult<Car> GetById(int id)
        {
            return new DataSuccessResult<Car>(_carDal.Get(p => p.Id == id),Message.SuccessGet);
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Message.SuccessUpdated);
        }
    }
}
