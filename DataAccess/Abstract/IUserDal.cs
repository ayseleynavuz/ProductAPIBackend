using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IUserDal
    {
        void Add(User user);
        User Get(Func<User, bool> value);

        List<OperationClaim> GetClaims(User user);

    }
}
