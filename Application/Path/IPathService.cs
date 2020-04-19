using Application.AppCourse;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Path
{
    public interface IPathService
    {
        PathDetailsModel GetPathDetails(int id);
        IEnumerable<PathModel> GetPathes();
        void DeletePath(int id);
        void UpdatePath(UpdatePathDto model);
        int CreatePath(CreatePathDto model);
    }
}
