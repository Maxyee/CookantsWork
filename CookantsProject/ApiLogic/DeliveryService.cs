using CookantsEntity.Model;
using CookantsRepository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookantsService.Services
{
    #region DeliveryGroupService Interface
    public interface IDeliveryGroupService
    {
        IEnumerable<DeliveryGroup> GetAll();
        DeliveryGroup GetDeliveryGroupById(int id);
        bool Insert(DeliveryGroup deliveryGroup);
        bool Update(int id, DeliveryGroup deliveryGroup);
        bool Delete(int id);
        List<object> DeliveryManProfile(int id);
        List<object> DeliveryList(int id);
        List<object> ConfirmDelivery(int id);
    }
    #endregion
    #region DeliveryGroupService Implementation
    public class DeliveryGroupService : IDeliveryGroupService
    {
        private readonly IDeliveryGroupRepository _deliveryGroupRepository;
        private readonly ISecurityUserRepository _securityUserRepository;
        private readonly ISubZoneRepository _subZoneRepository;
        private readonly IAddressRepository _addressRepository;
        private readonly IOrderRepository _orderRepository;

        public DeliveryGroupService(IDeliveryGroupRepository deliveryGroupRepository, ISecurityUserRepository securityUserRepository, ISubZoneRepository subZoneRepository, IAddressRepository addressRepository, IOrderRepository orderRepository)
        {
            _deliveryGroupRepository = deliveryGroupRepository;
            _securityUserRepository = securityUserRepository;
            _subZoneRepository = subZoneRepository;
            _addressRepository = addressRepository;
            _orderRepository = orderRepository;
        }

        public IEnumerable<DeliveryGroup> GetAll()
        {
            return _deliveryGroupRepository.GetAll();
        }

        public DeliveryGroup GetDeliveryGroupById(int id)
        {
            return _deliveryGroupRepository.FindById(a => a.Id == id);
        }

        public bool Insert(DeliveryGroup deliveryGroup)
        {
            _deliveryGroupRepository.Insert(deliveryGroup);
            return _deliveryGroupRepository.Save() > 0;
        }

        public bool Update(int id, DeliveryGroup deliveryGroup)
        {
            DeliveryGroup deliveryGroups = _deliveryGroupRepository.FindById(a => a.Id == id);
            deliveryGroups.DeliveryBoyId = deliveryGroup.DeliveryBoyId;
            deliveryGroups.Priority = deliveryGroup.Priority;
            deliveryGroups.SubZoneId = deliveryGroup.SubZoneId;
            _deliveryGroupRepository.Update(deliveryGroup);
            return _deliveryGroupRepository.Save() > 0;
        }

        public bool Delete(int id)
        {
            _deliveryGroupRepository.Delete(_deliveryGroupRepository.FindById(a => a.Id == id));
            return _deliveryGroupRepository.Save() > 0;
        }

        //DeliveryManProfile Method/Linq created by Julhas
        public List<object> DeliveryManProfile(int id)
        {

            return new List<object>((from u in _deliveryGroupRepository.GetAll().ToList()
                                     join m in _securityUserRepository.GetAll().ToList() on u.DeliveryBoyId equals m.Id
                                     join ms in _subZoneRepository.GetAll().ToList() on u.SubZoneId equals ms.Id
                                     where u.DeliveryBoyId == id
                                     select new { u.DeliveryBoyId, m.FirstName, m.LastName, zone = ms.Name }).ToList());

        }

        //DeliveryList Method/LinQ created by Julhas
        public List<object> DeliveryList(int id)
        {
            return new List<object>((from u in _securityUserRepository.GetAll().ToList()
                                     join m in _orderRepository.GetAll().ToList() on u.Id equals m.CustomerId
                                     join ms in _addressRepository.GetAll().ToList() on m.AddressId equals ms.Id
                                     where m.CustomerId == id
                                     select new { m.CustomerId, u.FirstName, u.LastName, m.Id, m.PaymentStatus, m.Phone, ms.Description, ms.Latlng, ms.RoadNo, ms.HouseNo, ms.FlatNO}).ToList());
        }

        //confirmDelivery Method/LinQ created by Julhas
        public List<object> ConfirmDelivery(int id)
        {
            //var ordertabledata = _orderRepository.GetAll().FirstOrDefault(x => x.Id == id);
            //var identify = ordertabledata.FirstOrDefault(x => x.Id == id);
            //var finddata = _orderRepository.FindById(x => x.Id == id);
            //bool value = finddata.PaymentStatus; 
            //var ordertabledata = _orderRepository.GetAll().FirstOrDefault(x => x.Id == id);
            //var identify = (from m in _orderRepository.GetAll().ToList()
            //                where m.Id == id
            //                select m);
            //var address = _addressRepository.GetAll().ToList();

            //var data = _orderRepository.FindById(u => u.Id == id);
            //var alldata = _orderRepository.GetAll().ToList();
            //if(data.PaymentStatus)
            //{
            //    return new List<object>(alldata);
            //}
            //return new List<object>(address);

            //var OrderData = _orderRepository.GetAll().ToList();
            //var Identify = OrderData.FirstOrDefault(z => z.Id == id && z.PaymentStatus == false);

            //bool data = Convert.ToBoolean(identify); 

            //if (Identify != null)
            //{
            //    List<object> items = new List<object>
            //    {
            //       new { orderId=Identify.Id, Payment="Due", Commnets = "Delivery Not Confirmed" }
            //    };

            //    return items;
            //}
            //else
            //{
            //    List<object> items = new List<object>
            //    {
            //       new { orderId=Identify.Id, Payment="Paid", Commnets = "Delivery Confirmed" }
            //    };

            //    return items;
            //}
            return null;
        }
    }
    #endregion
}
