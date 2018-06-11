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