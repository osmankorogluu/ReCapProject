using Core.Entites.Concrete;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<OperationClaim>> GetClaims(User user);
        IDataResult<List<User>> GetAll();
        IResult Add(User user);//yapim diğerlerini
        IResult Delete(User user);
        IResult Update(User user);
        IDataResult<User> GetByMail(string email);
    }
}
