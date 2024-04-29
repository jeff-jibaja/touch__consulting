﻿using DemoLibrary.Application.Models.Database;
using DemoLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DemoLibrary.Common.Helpers.BaseEnums;

namespace DemoLibrary.Application.Handlers.Commands.PersonController.Update
{

    public class UpdateSPRequest 
    {
        public ModelPerson Person { get; set; }
        public List<AttachedFilesUpdateSP> ListAttachedFile { get; set; }

    }

    public class AttachedFilesUpdateSP
    {
        public Guid IdAttachedFile { get; set; }
        public string Name { get; set; }
        public string PathFile { get; set; }
        public string UserRecordCreation { get; set; }
        public DateTime RecordCreationDate { get; set; }
        public string UserEditRecord { get; set; }
        public DateTime? RecordEditDate { get; set; }
        public string RecordStatus { get; set; }
        public StatusFile StatusFile { get; set; }
    }


}
