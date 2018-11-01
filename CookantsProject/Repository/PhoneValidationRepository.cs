using CookantsEntity;
using CookantsEntity.Model;

namespace CookantsRepository.Repository
{
    
        #region // User Details Repository Interface
        public interface IPhoneValidationRepository : IGenericRepository<Phonevalidation>
        {

        }
        #endregion

        #region User Details Repository Implementation
        public class PhoneValidationRepository :
            GenericRepository<CookAntsDbContext, Phonevalidation>, IPhoneValidationRepository
    {

        }
        #endregion
    
}
