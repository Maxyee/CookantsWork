using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.OData;
using CoockantsWeb.Helper;
using CookantsEntity.Model;
using CookantsService.Services;

namespace CoockantsWeb.Api
{

    [RoutePrefix("api/v1/UserPoints")]
    public class UserPointsController : ApiController
    {
        private readonly IUserPointService _userPointService;
        public UserPointsController(IUserPointService userPointService)
        {
            _userPointService = userPointService;
        }
        [HttpGet]
        [EnableQuery]
        [Route("GetSearching")]
        public IHttpActionResult GetSearching() // Odata Searching
        {
            return Ok(_userPointService.GetSearching());
        }
        // GET: api/UserPoints
        [HttpGet]
        [Route("GetAll")]
        public IHttpActionResult GetAll()
        {
            List<UserPoint> list = _userPointService.GetAll().ToList();
            if (list.Count > 0) return Ok(JsonStatus.DataFound(list));
            return Ok(JsonStatus.NotFound());
        }

        // GET: api/UserPoints/5
        [HttpGet]
        [Route("GetUserPointById/{id}")]
        public IHttpActionResult GetUserReferencePointById(int id)
        {
            UserPoint userPoint = _userPointService.GetUserReferencePointById(id);
            if (userPoint != null) return Ok(JsonStatus.DataFound(userPoint));
            return Ok(JsonStatus.NotFound());
        }

        [HttpGet]
        [Route("isExist/{customerId}/{orderItemId}")]
        public IHttpActionResult isExist(int customerId,int orderItemId)
        {
            if (_userPointService.isRating(customerId, orderItemId))
            {
                return Ok(JsonStatus.CustomMessage(true, true, "Already rating for this order item"));

            }
            else
            {
                return Ok(JsonStatus.CustomMessage(false, false, "Not Rated"));

            }
}



        // PUT: api/UserPoints/5
        [HttpPut]
        [Route("Update/{id}")]
        public IHttpActionResult Update(int id, [FromBody] UserPoint userPoint)
        {
            return Ok(_userPointService.Update(id, userPoint) ? JsonStatus.UpdateSuccess(userPoint) : JsonStatus.UpdateFaild());
        }

        // POST: api/UserPoints
        [HttpPost]
        [Route("Insert")]
        public IHttpActionResult Insert([FromBody] UserPoint userPoint)
        {
            if (_userPointService.isRating(userPoint.ReferenceByUserId, userPoint.OrderItemId))
            {
                return Ok(JsonStatus.CustomMessage(false, null, "Already rating for this order item"));

            }
            else
            {
                return Ok(_userPointService.Insert(userPoint) ? JsonStatus.SaveSuccess(userPoint) : JsonStatus.SaveFaild());


            }
        }

        // DELETE: api/UserPoints/5
        [HttpDelete]
        [Route("Delete/{id}")]
        public IHttpActionResult Delete(int id)
        {
            return Ok(_userPointService.Delete(id) ? JsonStatus.DeleteSuccess() : JsonStatus.DeleteFaild());
        }
        // GET: api/UserPoints/5
        [HttpGet]
        [Route("GetUserPointByUserId/{userId}")]
        public IHttpActionResult GetUserPointByAnyUserId(int userId)
        {
            List<UserPoint> userPoint = _userPointService.GetUserPointByAnyUserId(userId);
            if (userPoint.Count > 0) return Ok(JsonStatus.DataFound(userPoint));
            return Ok(JsonStatus.NotFound());
        }
    }
}