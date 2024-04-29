using AutoMapper;
using DemoLibrary.Application.Handlers.Commands.PersonController.Update;
using DemoLibrary.Application.Models.Database;
using DemoLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Application.Mappings
{
    public class AttachedFileProfile: Profile
    {
        public AttachedFileProfile()
        {
            CreateMap<ModelAttachedFile, AttachedFile>();
            CreateMap<AttachedFile, ModelAttachedFile>();
             
            CreateMap<AttachedFile, AttachedFilesUpdate>();
            CreateMap<AttachedFilesUpdate, AttachedFile>();
        }
    }
}
