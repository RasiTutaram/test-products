using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test_products.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public void Add()
        {
            int a = 5;
            int b = 10;
            int c=a + b;
        }
        public void Sub()
        {

            int i = 20;
            int j = 5;
            int k = i - j;
        }


    }
}
