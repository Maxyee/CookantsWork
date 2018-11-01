using CookantsEntity;
using CookantsEntity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookantsRepository.Repository
{
    #region // PickUpGroupRepository Interface
    public interface IPickUpGroupRepository : IGenericRepository<PickUpGroup>
    {

    }
    #endregion

    #region PickUpGroupRepository Implementation
    public class PickUpGroupRepository :
        GenericRepository<CookAntsDbContext, PickUpGroup>, IPickUpGroupRepository
    {

    }
    #endregion
}
