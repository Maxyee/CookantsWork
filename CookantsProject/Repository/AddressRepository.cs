using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookantsEntity;
using CookantsEntity.Model;

namespace CookantsRepository.Repository
{
 
    #region // Address Repository Interface
    public interface IAddressRepository : IGenericRepository<Address>
    {

    }
    #endregion

    #region Address Repository Implementation
    public class AddressRepository :
        GenericRepository<CookAntsDbContext, Address>, IAddressRepository
    {

    }
    #endregion
}
