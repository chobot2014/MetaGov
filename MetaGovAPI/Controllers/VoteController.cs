using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MetaGovAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    public class VoteController : Controller
    {      
        [HttpPost]
        public ActionResult Test(string voteID)
        {
            return Json(new { VoteTestResult = "Vote Test good!" + voteID });
        }
        
    }
}
