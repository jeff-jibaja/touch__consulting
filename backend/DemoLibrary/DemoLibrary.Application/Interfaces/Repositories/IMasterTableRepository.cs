using DemoLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Application.Interfaces.Repositories
{
    public interface IMasterTableRepository 
    {
        Task<DataTable> FindAllByStoreProcedure(CancellationToken cancellationToken = default);

    }

}
