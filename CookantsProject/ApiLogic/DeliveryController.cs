using System;
using System.Collections.Generic;
using CookantsService.Services;
using CoockantsWeb.Helper;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CoockantsWeb.Api
{
    [AllowAnonymous]
    [RoutePrefix("api/delivery")]
    public class DeliveryController : ApiController
    {

        private readonly ISecurityUserService _securityUserService;
        private readonly IDeliveryGroupService _deliveryGroupService;
        
        public DeliveryController(ISecurityUserService securityUserService, IDeliveryGroupService deliveryGroupService)
        {
            _securityUserService = securityUserService;
            _deliveryGroupService = deliveryGroupService;
        }


        // GET api/<deliveryManProfile>
        [HttpGet]
        [Route("deliveryManProfile")]
        public IHttpActionResult DeliveryManProfile(int id) // this id is deliveryBoyId
        {
            List<object> list = _deliveryGroupService.DeliveryManProfile(id);
            if (list.Count > 0) return Ok(JsonStatus.DataFound(list));
            return Ok(JsonStatus.NotFound());         
        }

        //GET api/<deliveryList>
        [HttpGet]
        [Route("deliveryList")]
        public IHttpActionResult DeliveryList(int id) //this id is customerId
        {
            List<object> list = _deliveryGroupService.DeliveryList(id);
            if (list.Count > 0) return Ok(JsonStatus.DataFound(list));
            return Ok(JsonStatus.NotFound());
        }

        //POST api/<confirmDelivery>
        [HttpPost]
        [Route("confirmDelivery")]
        public IHttpActionResult ConfirmDelivery([FromBody] int id) // this id is orderId
        {
            List<object> list = _deliveryGroupService.ConfirmDelivery(id);
            if (list.Count > 0) return Ok(JsonStatus.DataFound(list));
            return Ok(JsonStatus.NotFound());
        }
    }
}