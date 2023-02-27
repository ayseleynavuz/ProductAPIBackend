using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Tests.Helpers.MockInterfaces
{
    public interface IDbSets
    {
        DbSet<OperationClaim> OperationClaims { get; set; }
        DbSet<User> Users { get; set; }

    }
}