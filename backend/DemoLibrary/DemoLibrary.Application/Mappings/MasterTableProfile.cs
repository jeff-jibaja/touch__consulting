using AutoMapper;
using DemoLibrary.Application.Models.Database;
using DemoLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Application.Mappings
{
    public class MasterTableProfile : Profile
    {
        public MasterTableProfile()
        {
            CreateMap<ModelMasterTable, MasterTable>();
            CreateMap<MasterTable, ModelMasterTable>();
        }

    }

}
