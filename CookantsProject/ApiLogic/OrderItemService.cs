//Method for ScheduleMenuWithPagenoAndDateAndBusinessZoneId ----->Julhas/Eyamin
public List<object> ScheduleMenuWithPagenoAndDateAndBusinessZoneId(int pageno, string date, int businesszoneid)
{
    var datetime = Convert.ToDateTime(date);
    int pagevaluesize = 10;
    var menuScheduleAlldata = _menuScheduleRepository.GetAll().ToList();
    var items = menuScheduleAlldata.Skip((pageno - 1) * pagevaluesize).Take(pagevaluesize).Where(x => x.BusinessZoneId == businesszoneid && x.Date == datetime).OrderByDescending(a => a.Id).ToList();
    return new List<object>(items);
}

//Method for ScheduleMenuWithPagenoAndDateAndBusinessZoneIdAndMealId ------> Julhas/Eyamin
public List<object> ScheduleMenuWithPagenoAndDateAndBusinessZoneIdAndMealId(int pageno,string date,int businesszoneid, int mealid)
{
    var datetime = Convert.ToDateTime(date);
    int pagevaluesize = 10;
    var menuScheduleAlldata = _menuScheduleRepository.GetAll().ToList();
    var items = menuScheduleAlldata.Skip((pageno - 1) * pagevaluesize).Take(pagevaluesize).Where(x => x.BusinessZoneId == businesszoneid && x.Date == datetime && x.MealId == mealid).OrderByDescending(a => a.Id).ToList();
    return new List<object>(items);
}



// Method for GetAllOrderItemByCustomerIdWithPagenoAndDecendingOrder -----> Julhas/Eyamin
public List<object> GetAllOrderItemByCustomerIdWithPagenoAndDescendingOrder(int customerId, int pageno)
{
    int pagevaluesize = 10;
    var oderItemTableData = (from order in _orderRepository.GetAll(s => s.CustomerId.Equals(customerId)).ToList().OrderByDescending(a => a.Id)
                                join orderItem in _orderItemRepository.GetAll().ToList() on order.Id equals orderItem.OrderId
                                select new { orderItems = orderItem });

    var items = oderItemTableData.Skip((pageno - 1) * pagevaluesize).Take(pagevaluesize).ToList();
    return new List<object>(items);           
}



// Method for GetAllChefByCustomerIdWithPagenoAndDescendingOrder -----> Julhas/Eyamin
public List<object> GetAllChefByCustomerIdWithPagenoAndDescendingOrder(int customerId, int pageno)
{
    int pagevaluesize = 10;

    var ChefDetails = (from order in _orderRepository.GetAll(s => s.CustomerId.Equals(customerId)).ToList().OrderByDescending(a => a.Id)
                        join orderItem in _orderItemRepository.GetAll().ToList() on order.Id equals orderItem.OrderId
                        join menuItem in _menuItemRepository.GetAll().ToList() on orderItem.MenuItemId equals menuItem.Id
                        join securityUser in _securityUserRepository.GetAll().ToList() on menuItem.CookId equals securityUser.Id
                        select new { ChefDetails = securityUser });

    //var ChefDetails = (from order in _orderRepository.GetAll(s => s.CustomerId.Equals(customerId)).ToList().OrderByDescending(a => a.Id)
    //                   join securityUser in _securityUserRepository.GetAll().ToList() on order.CustomerId equals securityUser.Id
    //                   select new { ChefDetails = securityUser }); //OrderByDescending(a => a.Id).ToList()

    var items = ChefDetails.Skip((pageno - 1) * pagevaluesize).Take(pagevaluesize).ToList();
    return new List<object>(items);
}