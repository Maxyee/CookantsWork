using CookantsEntity;
using CookantsEntity.Model;

namespace CookantsRepository.Repository
{
    
    #region // User Details Repository Interface
    public interface IMenuCategoryRepository : IGenericRepository<MenuCategory>
    {

    }
    #endregion

    #region User Details Repository Implementation
    public class MenuCategoryRepository :
        GenericRepository<CookAntsDbContext, MenuCategory>, IMenuCategoryRepository
    {

    }
    #endregion
}
