using CookantsEntity;
using CookantsEntity.Model;

namespace CookantsRepository.Repository
{
    #region // User Details Repository Interface
    public interface IFavouritMenuRepository : IGenericRepository<FavouriteMenu>
    {

    }
    #endregion

    #region User Details Repository Implementation
    public class FavouritMenuRepository :
        GenericRepository<CookAntsDbContext, FavouriteMenu>, IFavouritMenuRepository
    {

    }
    #endregion
}
