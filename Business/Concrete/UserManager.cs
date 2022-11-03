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
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult(Message.SuccessAdded);
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult(Message.SuccessDeleted);
        }

        public IDataResult<User> Get(int Id)
        {
            return new DataSuccessResult<User>(_userDal.Get(p => p.Id == Id), Message.SuccessGet);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new DataSuccessResult<List<User>>(_userDal.GetAll(), Message.SuccessGet);
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult(Message.SuccessUpdated);
        }
    }
}
