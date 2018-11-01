using CookantsEntity;
using CookantsEntity.Model;

namespace CookantsRepository.Repository
{

    #region // User Details Repository Interface
    public interface IMenuScheduleRepository : IGenericRepository<MenuSchedule>
    {

    }
    #endregion

    #region User Details Repository Implementation
    public class MenuScheduleRepository :
        GenericRepository<CookAntsDbContext, MenuSchedule>, IMenuScheduleRepository
    {

    }
    #endregion
}
