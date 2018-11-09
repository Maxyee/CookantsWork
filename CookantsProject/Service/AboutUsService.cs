using CookantsEntity.Model;
using CookantsRepository.Repository;


namespace CookantsService.Services
{
   
    #region // Business Zone Service Interface
    public interface IAboutUsService
    {
        AboutUs GetDetails( int id);
        bool Update(int id, AboutUs aboutUs);
    }
    #endregion
    #region // Business Zone Service Implementation
    public class AboutUsService : IAboutUsService
    {
        private readonly IAboutUsRepository _aboutUsRepository;
        public AboutUsService(IAboutUsRepository aboutUsRepository)
        {
            _aboutUsRepository = aboutUsRepository;
        }
        public AboutUs GetDetails(int id)
        {
            return _aboutUsRepository.FindById(a => a.Id == id);
        }
        public bool Update(int id, AboutUs aboutUs)
        {
            AboutUs newContactUs = _aboutUsRepository.FindById(a => a.Id == id);
            newContactUs.Title = aboutUs.Title;
            newContactUs.ShortDescription = aboutUs.ShortDescription;
            newContactUs.LongDescription = aboutUs.LongDescription;
            newContactUs.RootUrl = aboutUs.RootUrl;
            newContactUs.FileExtention = aboutUs.FileExtention;
            newContactUs.FileName = aboutUs.FileName;
            _aboutUsRepository.Update(newContactUs);
            return _aboutUsRepository.Save() > 0;
        }
    }
    #endregion
}
