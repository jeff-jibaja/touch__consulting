using AutoMapper;
using DemoLibrary.Application.Interfaces.Repositories;
using DemoLibrary.Application.Models.Database;
using DemoLibrary.Common.Helpers;
using DemoLibrary.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Reec.Inspection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Application.Handlers.Queries.BookController.FindAll
{
    public class FindAll : IRequest<List<ModelBook>>
    {
        public BookFindAllRequest bookFindAllRequest { get; }
        public FindAll(BookFindAllRequest _bookFindAllRequest)
        {
            bookFindAllRequest = _bookFindAllRequest;
        }


        public class FindAllHandler : IRequestHandler<FindAll, List<ModelBook>>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            

            public FindAllHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                _unitOfWork = unitOfWork;
                _mapper = mapper;

            }


            public async Task<List<ModelBook>> Handle(FindAll request, CancellationToken cancellationToken)
            {
                var listEntity = await _unitOfWork.Books.AsNoTracking().Where(x => x.RecordStatus == ConstantBase.Active).ToListAsync(cancellationToken);
                if (listEntity == null || listEntity.Count == 0)
                    throw new ReecException(ReecEnums.Category.PartialContent, ConstantMessage.NotRecords);

                var result = _mapper.Map<List<ModelBook>>(listEntity);
                return result;
            }
        }
    }


}
