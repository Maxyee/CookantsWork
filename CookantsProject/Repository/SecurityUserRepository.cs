using CookantsEntity;
using CookantsEntity.Model;

namespace CookantsRepository.Repository
{
    #region //User Repository Interface
    public interface ISecurityUserRepository : IGenericRepository<SecurityUser>
    {

    }
    #endregion


    #region User Repository Implementation
    public class SecurityUserRepository :
       GenericRepository<CookAntsDbContext, SecurityUser>, ISecurityUserRepository
    {

    }
    #endregion
}
