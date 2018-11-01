using CookantsEntity;
using CookantsEntity.Model;


namespace CookantsRepository.Repository
{

    #region // ContactUsRepository  Interface
    public interface IContactUsRepository : IGenericRepository<ContactUs>
    {

    }
    #endregion

    #region ContactUsRepository  Implementation
    public class ContactUsRepository :
        GenericRepository<CookAntsDbContext, ContactUs>, IContactUsRepository
    {

    }
    #endregion

}
