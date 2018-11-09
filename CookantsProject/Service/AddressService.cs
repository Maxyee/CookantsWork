using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookantsEntity.Model;
using CookantsRepository.Repository;

namespace CookantsService.Services
{
    public interface IAddressService
    {
        IQueryable<Address> GetAll();
        Address GetAddressById(int id);
        Address GetFullAddressById(int id);
        bool Insert(Address address);
        bool Insert(Address address,int customerId, int addressType);
        bool Update(int id, Address address);
        bool Update(int id, Address address, int customerId, int addressType);
        bool Delete(int id);
    }
    public class AddressService : IAddressService
    {
        private readonly IAddressRepository _addressRepository;
        private readonly ISecurityUserRepository _securityRepository;

        public AddressService(IAddressRepository addressRepository, ISecurityUserRepository securityRepository)
        {
            _addressRepository = addressRepository;
            _securityRepository = securityRepository;
        }
        public IQueryable<Address> GetAll()
        {
            return _addressRepository.GetAll(a => a.BusinessZone);
        }

        public Address GetAddressById(int id)
        {
            return _addressRepository.FindById(a => a.Id.Equals(id), a => a.BusinessZone);
        }

        public bool Insert(Address address)
        {
            _addressRepository.Insert(address);
            return _addressRepository.Save() > 0;
        }

        public bool Insert(Address address,int customerId, int addressType)
        {
             _addressRepository.Insert(address);
            _addressRepository.Save();
            SecurityUser securityUser = _securityRepository.FindById(a=> a.Id.Equals(customerId));
            if(addressType==1)
            {
                securityUser.HomeAddressId = address.Id;
             
            }
            else if(addressType == 2)
            {
                securityUser.OfficeAddressId = address.Id;
            }
            else if(addressType == 3)
            {
                securityUser.OtherAddressId = address.Id;
            }
            _securityRepository.Update(securityUser);
            return _securityRepository.Save() > 0;
        }
        public bool Update(int id, Address address, int customerId, int addressType)
        {
            Address newAddress = _addressRepository.FindById(a => a.Id.Equals(id));
            newAddress.BusinessZoneId = address.BusinessZoneId;
            newAddress.SubZoneId = address.SubZoneId;
            newAddress.Description = address.Description;
            _addressRepository.Update(newAddress);
            _addressRepository.Save();
            SecurityUser securityUser = _securityRepository.FindById(a => a.Id.Equals(customerId));
            if (addressType == 1)
            {
                securityUser.HomeAddressId = address.Id;

            }
            else if (addressType == 2)
            {
                securityUser.OfficeAddressId = address.Id;
            }
            else if (addressType == 3)
            {
                securityUser.OtherAddressId = address.Id;
            }
            _securityRepository.Update(securityUser);


            return _securityRepository.Save() > 0;
        }
        public bool Update(int id, Address address)
        {
            Address newAddress = _addressRepository.FindById(a => a.Id.Equals(id));
            newAddress.BusinessZoneId = address.BusinessZoneId;
            newAddress.SubZoneId = address.SubZoneId;
            newAddress.Description = address.Description;
            _addressRepository.Update(newAddress);
           return _addressRepository.Save() > 0;
        }

        public bool Delete(int id)
        {
            _addressRepository.Delete(_addressRepository.FindById(a => a.Id.Equals(id)));
            return _addressRepository.Save() > 0;
        }

        public Address GetFullAddressById(int id)
        {
            return _addressRepository.FindById(a => a.Id.Equals(id), a => a.BusinessZone.BusinessAreas, a => a.SubZones);
        }
    }
}
