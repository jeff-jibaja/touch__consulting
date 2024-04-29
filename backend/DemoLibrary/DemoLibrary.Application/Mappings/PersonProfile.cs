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
    public class PersonProfile: Profile
    {
        public PersonProfile()
        {
            CreateMap<ModelPerson, Person>();
            CreateMap<Person, ModelPerson>();
        }
    }

}
