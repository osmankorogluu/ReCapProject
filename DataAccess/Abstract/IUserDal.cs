using System;
using Core.DataAccsess;
using System.Text;
using Core.Entites.Concrete;
using System.Collections.Generic;
using Core.DataAccess;
using Core.Utilities.Results;

namespace DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}
