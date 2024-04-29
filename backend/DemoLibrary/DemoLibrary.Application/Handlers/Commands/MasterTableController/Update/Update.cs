﻿using AutoMapper;
using MediatR;
using DemoLibrary.Application.Interfaces.Repositories;
using Ent = DemoLibrary.Domain.Entities;
using Reec.Inspection;
using Microsoft.EntityFrameworkCore;
using DemoLibrary.Application.Models.Database;

namespace DemoLibrary.Application.Handlers.Commands.MasterTableController.Update
{
    public class Update : IRequest<ModelMasterTable>
    {
        public ModelMasterTable ModelMasterTable { get; }
        public Update(ModelMasterTable modelMasterTable)
        {
            ModelMasterTable = modelMasterTable;
        }

        public class UpdateHandler : IRequestHandler<Update, ModelMasterTable>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;

            public UpdateHandler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                _unitOfWork = unitOfWork;
                _mapper = mapper;
            }
            public async Task<ModelMasterTable> Handle(Update request, CancellationToken cancellationToken)
            {
                var isExists = await _unitOfWork.MasterTables.AsNoTracking()
                                .FirstOrDefaultAsync(t => t.IdMasterTable == request.ModelMasterTable.IdMasterTable);

                if (isExists == null)
                    throw new ReecException(ReecEnums.Category.Warning, "No exíste el registro.");


                var entity = _mapper.Map<Ent.MasterTable>(request.ModelMasterTable);
                entity.RecordEditDate = DateTime.Now;
                var entry = _unitOfWork.MasterTables.Update(entity);
                await _unitOfWork.SaveChangesAsync(cancellationToken);

                var result = _mapper.Map<ModelMasterTable>(entry.Entity);
                return result;

            }
        }


    }

}
