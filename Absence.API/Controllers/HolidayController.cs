using Absence.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Absence.API.Controllers
{

    [RoutePrefix("api/holiday")]
    public class HolidayController : ApiController
    {
        [Route("")]
        public IHttpActionResult Post([FromBody]HolidayRequest holidayRequest)
        {
            return Ok();
        }
    }
}
