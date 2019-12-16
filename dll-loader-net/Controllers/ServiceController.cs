using dll_loader_net.Models;
using SDK;
using SDK.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Web.Http;

namespace dll_loader_net.Controllers
{
    public class ServiceController : ApiController
    {
        // GET api/values
        [HttpPost]
        public string AddProviderScheduling([FromBody]AddProviderSchedulingEntity entity)
        {

            Service service = new Service();
            return service.AddProviderScheduling(entity.Provider,
                entity.HealthcareFacility,
               entity.StartDateTime,
               entity.DurationPerPatient,
               entity.QueueNumber,
               entity.Service,
               entity.Quota,
               entity.LocalID,
               entity.BookingStartDate,
               entity.BookingExpiryDate);
            //return "OK";
        }

    }
}
