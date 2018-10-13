using System;
using CookantsEntity.Model;
using CookantsRepository.Repository;
using CookantsService.Services;

namespace CoockantsWeb.Helper
{
   public class GetFileName
   {
       private readonly ISecurityUserService _securityUserService=new SecurityUserService(new UserPointRepository(), new SecurityUserRepository(),new AddressRepository());
       private readonly IMenuItemService _menuItemService =new MenuItemService(new MealTimeRepository(),new FavouritMenuRepository(), new MenuScheduleRepository(),new MenuItemRepository(), new SecurityUserRepository(),new UserPointRepository());
       public string GetUserFileName()
       {
            var guid = Guid.NewGuid().ToString();
            if (!_securityUserService.ExistFileName(new SecurityUser() { FileName = guid })) return guid;
            GetUserFileName();
            return guid;
      }
        public string GetMenuItemFileName()
        {
            var guid = Guid.NewGuid().ToString();
            if (!_menuItemService.ExistFileName(guid)) return guid;
            GetMenuItemFileName();
            return guid;
        }
    }
}
