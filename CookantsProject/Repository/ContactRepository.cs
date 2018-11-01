using CookantsEntity;
using CookantsEntity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookantsRepository.Repository
{
    #region // ContactRepository  Interface
    public interface IContactRepository : IGenericRepository<Contact>
    {

    }
    #endregion

    #region ContactRepository  Implementation
    public class ContactRepository :
        GenericRepository<CookAntsDbContext, Contact>, IContactRepository
    {

    }
    #endregion
}
