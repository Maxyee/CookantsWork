using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookantsEntity;
using CookantsEntity.Model;

namespace CookantsRepository.Repository
{
    #region // MealTime Repository Repository Interface
    public interface IMealTimeRepository : IGenericRepository<MealTime>
    {

    }
    #endregion

    #region MealTime Repository Repository Implementation
    public class MealTimeRepository :
        GenericRepository<CookAntsDbContext, MealTime>, IMealTimeRepository
    {

    }
    #endregion
}
