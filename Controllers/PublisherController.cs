using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookEshopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublisherController : ControllerBase
    {
        [HttpGet("{id:length(24)}", Name = "GetPublisher")]
        public ActionResult<Book> Get(string id)
        {
           // var book = _bookService.Get(id);

            //if (book == null)
            //{
                return NotFound();
           // }

           // return book;
        }
    }
}
