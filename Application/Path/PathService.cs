using Application.AppCourse;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application.Path
{
    public class PathService : IPathService
    {
        private readonly ClassLibraryDbContext _context;
        private readonly IMapper _mapper;

        public PathService(ClassLibraryDbContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public PathDetailsModel GetPathDetails(int id)
        {
            var data = _mapper.Map<PathDetailsModel>
                (_context.Paths
                .Include(x => x.Courses)
                .First(x =>
                x.Id == id
                && x.IsActive.Value
                && !x.IsDeleted.Value
                && !x.IsHidden.Value));

            if (data == null)
                throw new Exception("Not Found");

            return data;
        }

        public IEnumerable<PathModel> GetPathes()
        {
            var data = _context.Paths
                .Where(x =>
                x.IsActive.Value
                && !x.IsDeleted.Value
                && !x.IsHidden.Value);

            return _mapper.Map<IEnumerable<PathModel>>(data);
        }

        public void DeletePath(int id)
        {
            var data = _context.Paths.FirstOrDefault(x =>
            x.Id == id
            && x.IsActive.Value
            && !x.IsDeleted.Value
            && !x.IsHidden.Value);

            if (data == null)
                throw new Exception("Not Found");

            data.IsDeleted = true;
            data.IsHidden = true;
            data.IsActive = false;

            _context.Paths.Update(data);
            _context.SaveChanges();
        }

        public void UpdatePath(UpdatePathDto model)
        {
            var data = _context.Paths.FirstOrDefault(x =>
            x.Id == model.Id
            && x.IsActive.Value
            && !x.IsDeleted.Value
            && !x.IsHidden.Value);

            if (data == null)
                throw new Exception("Not Found");

            data.Name = model.Name;
            data.Description = model.Description;

            _context.Paths.Update(data);
            _context.SaveChanges();
        }


        public int CreatePath(CreatePathDto request)
        {
            var courses = new List<ClassLibrary1.Course>();
            foreach (var course in request.Courses)
            {
                var subData = new ClassLibrary1.Course(
                    course.Name,
                    course.Description,
                    course.PathId);
                courses.Add(subData);
            }

            var data = new ClassLibrary1.Path(request.Name, request.Description)
                .AddCourses(courses.ToArray());

            _context.Paths.Add(data);
            _context.SaveChanges();

            return data.Id;
        }
    }
}
