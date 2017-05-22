using Absence.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Absence.API.Controllers
{

    [RoutePrefix("api/holiday")]
    public class HolidayController : ApiController
    {
        [Route("")]
        public async Task<IHttpActionResult> Post([FromBody]HolidayRequest holidayRequest)
        {

            var parts = holidayRequest.DateRange.Split(new[] { " - " }, StringSplitOptions.RemoveEmptyEntries);

            var absence = new Models.Absence() {
                StartDate = DateTime.Parse(parts[0]),
                EndDate = DateTime.Parse(parts[1])
            };

            var absenceRepository = new Repositories.AbsenceRepository();
            await absenceRepository.Create(absence);

            return Ok();
        }

        [Route("")]
        public async Task<IHttpActionResult> Get()
        {
            
            var absenceRepository = new Repositories.AbsenceRepository();

            var model = await absenceRepository.List();

            var dates = model.SelectMany(a => Enumerable.Range(0, 1 + a.EndDate.Subtract(a.StartDate).Days)
                  .Select(offset => a.StartDate.AddDays(offset).ToString("yyyy-MM-dd"))
                  .ToArray());

            return Ok(dates);

        }
    }
}
