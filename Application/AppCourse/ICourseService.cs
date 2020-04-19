using Application.AppCourse;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Course
{
    public interface ICourseService
    {
        CourseDetailsModel GetCourseDetails(int id);
        IEnumerable<CourseModel> GetCourses();
        void DeleteCourse(int id);
        void UpdateCourse(UpdateCourseDto model);
        int CreateCourse(CreateCourseDto model);
    }
}
