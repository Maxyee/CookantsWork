using CookantsEntity;
using CookantsEntity.Model;

namespace CookantsRepository.Repository
{

    #region // User Details Repository Interface
    public interface IUserPointRepository : IGenericRepository<UserPoint>
    {

    }
    #endregion

    #region User Details Repository Implementation
    public class UserPointRepository :
        GenericRepository<CookAntsDbContext, UserPoint>, IUserPointRepository
    {

    }
    #endregion
}
