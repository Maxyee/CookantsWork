using CookantsEntity;
using CookantsEntity.Model;

namespace CookantsRepository.Repository
{

    #region // User Details Repository Interface
    public interface IMenuItemRepository : IGenericRepository<MenuItem>
    {

    }
    #endregion

    #region User Details Repository Implementation
    public class MenuItemRepository :
        GenericRepository<CookAntsDbContext, MenuItem>, IMenuItemRepository
    {

    }
    #endregion
}
