using Core.DataAccess.Concrete;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRespositoryBase<User, ReCapProjectContext>, IUserDal
    {
        public List<OperationClaim> GetOperationClaims(User user)
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                             on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.Id == user.Id
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList(); // istediğimiz userın claimlerini listeliyor                   
            }
        }

        public List<Customer> GetUsersCustomes(User user)
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var result = from usersCustomer in context.UserCustomers
                             join customer in context.Customers
                             on usersCustomer.Id equals customer.Id
                             where usersCustomer.UserId == user.Id
                             select new Customer { Id = customer.Id, CompanyName = customer.CompanyName };
                return result.ToList();
            }
        }
    }
}
