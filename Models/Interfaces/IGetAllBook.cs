using System;
using System.Collections.Generic;


namespace api.Models.Interfaces
{
    public interface IGetAllBook
    {
         List<Book> GetAllBooks();
    }
}