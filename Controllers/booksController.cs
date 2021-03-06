using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using api.Models;
using api.Models.Interfaces;
using Microsoft.AspNetCore.Cors;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class booksController : ControllerBase
    {
        // GET: api/books            getting from database
        [EnableCors("AnotherPolicy")]
        [HttpGet]
        public List<Book> Get()
        {
            IGetAllBook readObject = new ReadBookData();
            return readObject.GetAllBooks();
        }

        // GET: api/books/5
        [EnableCors("AnotherPolicy")]
        [HttpGet("{id}", Name = "Get")]
        public Book Get(int id)
        {
            IGetBook readObject = new ReadBookData();
            return readObject.GetBook(id);
        }

        // POST: api/books           inserting into database
        [EnableCors("AnotherPolicy")]
        [HttpPost]
        public void Post([FromBody] Book value)
        {
            IInsertBook insertObject = new SaveBook();
            insertObject.InsertBook(value);
        }

        // PUT: api/books/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/books/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
