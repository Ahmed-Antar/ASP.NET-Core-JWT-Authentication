using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace ASP.NET_Core_JWT_Authentication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
	  // GET api/values
	  [HttpGet,Authorize]
	   public IEnumerable<string> Get()
	   {
		   return new string[] { "John Doe", "Jane Doe" };
	    }
 
}

}