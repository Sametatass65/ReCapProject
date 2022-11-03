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
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            _rentalDal.Add(rental);
            return new SuccessResult(Message.SuccessAdded);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Message.SuccessDeleted);
        }

        public IDataResult<Rental> Get(int Id)
        {
            return new DataSuccessResult<Rental>(_rentalDal.Get(p => p.Id == Id), Message.SuccessGet);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new DataSuccessResult<List<Rental>>(_rentalDal.GetAll(), Message.SuccessGet);
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Message.SuccessUpdated);
        }
    }
}
