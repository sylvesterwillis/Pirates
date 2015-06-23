using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Pirates.Controllers {
    public class PiratesController : ApiController {
        const int ALLOWED_PIRATES = 1000;
        public IHttpActionResult GetGold(int pirateCount) {
            long result = 1;

            if (pirateCount >= ALLOWED_PIRATES) {
                return Ok("Number of pirates must be lower than 1000.");
            }
            if (pirateCount <= 0)
            {
                return Ok("Number of pirates must be greater than 0.");
            }

            for (int i = 0; i <= pirateCount; i++) {
                result = (result * pirateCount) + 1;
            }

            return Ok(result);
        }
    }
}
