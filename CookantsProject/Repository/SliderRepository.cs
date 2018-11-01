using CookantsEntity;
using CookantsEntity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookantsRepository.Repository
{

    #region // SliderRepository  Interface
    public interface ISliderRepository : IGenericRepository<Slider>
    {

    }
    #endregion

    #region SliderRepository  Implementation
    public class SliderRepository :
        GenericRepository<CookAntsDbContext, Slider>, ISliderRepository
    {

    }
    #endregion
}
