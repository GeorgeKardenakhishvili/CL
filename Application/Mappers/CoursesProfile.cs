using Application.AppCourse;
using Application.Course;
using Application.Path;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Mappers
{
    public class CoursesProfile : Profile
    {
        public CoursesProfile()
        {
            CreateMap<CreateCourseModel, CreateCourseDto>();
            CreateMap<UpdateCourseModel, UpdateCourseDto>();

            CreateMap<ClassLibrary1.Course, CourseDetailsModel>();
            CreateMap<ClassLibrary1.Course, CourseModel>();
        }
    }
}
