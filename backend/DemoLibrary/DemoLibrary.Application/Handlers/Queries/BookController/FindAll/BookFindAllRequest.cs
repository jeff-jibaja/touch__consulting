using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Application.Handlers.Queries.BookController.FindAll
{
    public class BookFindAllRequest
    {
        public String Param { get; set; }
        public string Value { get; set; }  
        public int PageNumber { get; set; }
        public int NumberOfRecord { get; set; }
    }
}
