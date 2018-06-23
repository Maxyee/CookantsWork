public string SendPickUpSms(int[] Id)
        {
            Message newMessage = new Message();
            string textmessage = "";

            List<OrderItem> orderitemList = new List<OrderItem>();
            foreach (int id in Id)
            {
                    orderitemList.Add(_orderItemRepository.FindById(a => a.OrderId.Equals(id), a => a.MenuItems.SecurityUserCooks));
            }
            foreach(var item in orderitemList.GroupBy(a=>a.MenuItems.SecurityUserCooks.Phone))
            {
                int quantity = 0;
                string name = "";
                foreach (var items in item)
                {
                    quantity += items.Quantity;
                    name = items.MenuItems.SecurityUserCooks.FullName;
                }
                textmessage += "Pickup:" + name +",Mobile:"+item.Key+",Q:"+quantity+".";
            }
            return textmessage;
        }
        public List<Message> SendDeliverySms(int[] Id)
        {
            List<Message> newMessage = new List<Message>();
            List<OrderItem> orderitemList = new List<OrderItem>();
            foreach (int id in Id)
            {
                orderitemList.Add(_orderItemRepository.FindById(a => a.OrderId.Equals(id), a => a.MenuItems.SecurityUserCooks, a => a.Orders.SecurityUserCustomers,a=>a.Orders.Addresss, a=>a.Orders.Addresss.BusinessZone,a=>a.Orders.Addresss.SubZones));
            }
            foreach (var item in orderitemList.GroupBy(a => a.Orders.SecurityUserCustomers.Phone))
            {
                int quantity = 0;
                string textmessage = "";
                decimal price = 0;
                string address = "";
                string chef = "";
                foreach (var itemss in item.GroupBy(a=>a.MenuItems.SecurityUserCooks.FullName))
                {
                    int quantitys = 0;
                    foreach (var items in itemss)
                    {
                        address = items.Orders.Addresss.Description + "," + items.Orders.Addresss.SubZones.Name;
                        quantity += items.Quantity;
                        quantitys += items.Quantity;
                        price += items.Price;
                        
                    }
                    chef += itemss.Key + "(" + quantitys + "),";
                }
                Message ms = new Message();
                textmessage +="Delivery:"+address+",Mobile:"+item.Key+",Q:"+quantity+",Price:"+price+",Chef Name:"+chef+".";
                ms.text = textmessage;
                newMessage.Add(ms);
            }

            return newMessage;
        }