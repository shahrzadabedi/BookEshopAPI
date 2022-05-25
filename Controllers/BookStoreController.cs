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
    public class BookStoreController : ControllerBase
    {
        private readonly BookStoreService _bookStoreService;

        public BookStoreController(BookStoreService bookStoreService)
        {
            _bookStoreService = bookStoreService;
        }
        [HttpGet("{id:length(24)}", Name = "GetBookStore")]
        public ActionResult<BookStore> Get(string id)
        {
            var book = _bookStoreService.Get(id);

            if (book == null)
            {
                return NotFound();
            }

            return book;
        }
        [HttpPost]
        public ActionResult<BookStore> Create(BookStore bookStore)
        {
            _bookStoreService.Create(bookStore);

            return CreatedAtRoute("GetBookStore", new { id = bookStore.Id.ToString() }, bookStore); // CreatedAtRoute returned in Response Header Location part
        }
    }
}
