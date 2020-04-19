using Application.Course;
using AutoMapper;
using Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application.AppCourse
{
    public class CourseService : ICourseService
    {
        private readonly ClassLibraryDbContext _context;
        private readonly IMapper _mapper;

        public CourseService(ClassLibraryDbContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public int CreateCourse(CreateCourseDto model)
        {
            var data = new ClassLibrary1.Course(model.Name, model.Description, model.PathId);

            _context.Courses.Add(data);
            _context.SaveChanges();

            return data.Id;
        }

        public void UpdateCourse(UpdateCourseDto model)
        {
            var data = _context.Courses
                .FirstOrDefault(
                x => x.Id == model.Id
                && x.IsActive.Value
                && !x.IsDeleted.Value
                && !x.IsHidden.Value);

            if (data == null)
                throw new Exception("Not Found");

            data.Name = model.Name;
            data.Description = model.Description;
            data.PathId = model.PathId;

            _context.Courses.Update(data);
            _context.SaveChanges();
        }


        public IEnumerable<CourseModel> GetCourses()
        {
            var data = _context.Courses
               .Where(x =>
               x.IsActive.Value
               && !x.IsDeleted.Value
               && !x.IsHidden.Value);

            return _mapper.Map<IEnumerable<CourseModel>>(data);
        }

        public CourseDetailsModel GetCourseDetails(int id)
        {
            var data = _context.Courses
                .FirstOrDefault(
                x => x.Id == id
                && x.IsActive.Value
                && !x.IsDeleted.Value
                && !x.IsHidden.Value);

            if (data == null)
                throw new Exception("Not Found");

            return _mapper.Map<CourseDetailsModel>(data);
        }

        public void DeleteCourse(int id)
        {
            var data = _context.Courses
                .FirstOrDefault(
                x => x.Id == id
                && x.IsActive.Value
                && !x.IsDeleted.Value
                && !x.IsHidden.Value);

            if (data == null)
                throw new Exception("Not Found");

            data.IsDeleted = true;
            data.IsHidden = true;
            data.IsActive = false;

            _context.Update(data);
            _context.SaveChanges();
        }
    }
}
