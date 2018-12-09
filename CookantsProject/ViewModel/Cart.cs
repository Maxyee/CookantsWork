using CookantsEntity.Model;


namespace CookantsEntity.ViewModel
{
    public class Cart
    {
        public MenuItem MenuItem { get; set; }
        public int Quantity { get; set; }
        public int MenuSheduleId { get; set; }

        public Cart(MenuItem menuItem, MenuSchedule mo)
        {
            MenuItem = menuItem;
            Quantity = mo.Quantity;
            MenuSheduleId = mo.Id;
        }
    }

}
