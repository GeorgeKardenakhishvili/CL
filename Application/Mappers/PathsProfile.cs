using Application.Path;
using AutoMapper;
using ClassLibrary1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application.Mappers
{
    public class PathsProfile : Profile
    {
        public PathsProfile()
        {
            CreateMap<CreatePathModel, CreatePathDto>();
            CreateMap<UpdatePathModel, UpdatePathDto>();

            CreateMap<ClassLibrary1.Path, Path.PathDetailsModel>()
                .ForMember(x => x.Courses, opt => opt.MapFrom(m =>
                  m.Courses.Where(
                      w => w.IsActive.HasValue
                      && !w.IsDeleted.Value
                      && !w.IsHidden.Value)));
            CreateMap<ClassLibrary1.Path, Path.PathModel>();
        }
    }
}
