using Core.Entities.Concrete;
using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<List<OperationClaim>> GetByUsersOperationClaim(User user);
        IDataResult<List<Customer>> GetByUsersCustomer(User user);
        IDataResult<User> Get(string email);
        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);
    }
}
