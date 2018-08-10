using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace test2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public ActionResult<string> Get() {
            string file = "/storage/test.txt";
            try
            {
                return System.IO.File.ReadAllText(file);
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
