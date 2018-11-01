using CookantsEntity;
using CookantsEntity.Model;


namespace CookantsRepository.Repository
{

    #region // Cater Repository  Interface
    public interface ICaterRepository : IGenericRepository<Cater>
    {

    }
    #endregion

    #region Cater Repository  Implementation
    public class CaterRepository :
        GenericRepository<CookAntsDbContext, Cater>, ICaterRepository
    {

    }
    #endregion
}
