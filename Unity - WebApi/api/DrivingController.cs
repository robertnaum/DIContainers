using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessLibrary;

namespace Unity___WebApi.api
{
    [RoutePrefix("api/driving")]
    public class DrivingController : ApiController
    {
        private IDrivable _drivable;
        public DrivingController(IDrivable drivable)
        {
            _drivable = drivable;
        }

        [Route("Status")]
        public IHttpActionResult GetStatus()
        {
            return Ok(_drivable.Drive());
        }
    }
}
