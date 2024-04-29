using DemoLibrary.Application.Handlers.Queries.BookController.FindAll;
using DemoLibrary.Application.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Application.Interfaces.Repositories
{
    public interface IBookRepository
    {
        Task<IEnumerable<BokkFindResponse>> CreateAndUpdateByStoredProcedure(BookFindAllRequest person);

    }
}
