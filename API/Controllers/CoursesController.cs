using Application.AppCourse;
using Application.Course;
using Application.Path;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseService _courseService;
        private readonly IMapper _mapper;

        public CoursesController(
            ICourseService courseService,
            IMapper mapper)
        {
            _courseService = courseService;
            _mapper = mapper;
        }

        [HttpGet()]
        public ActionResult GetCources()
        {
            return Ok(_courseService.GetCourses());
        }

        [HttpGet("{id}")]
        public ActionResult GetCourse([FromRoute] int id)
        {
            return Ok(_courseService.GetCourseDetails(id));
        }

        [HttpPost()]
        public ActionResult CreateCourse([FromBody] CreateCourseModel request)
        {
            var dto = _mapper.Map<CreateCourseDto>(request);
            var id = _courseService.CreateCourse(dto);
            return Ok(id);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateCourse([FromRoute] int id, UpdateCourseModel request)
        {
            var dto = _mapper.Map<UpdateCourseDto>(request);
            dto.Id = id;

            _courseService.UpdateCourse(dto);
            return Ok();

        }

        [HttpDelete("{id}")]
        public ActionResult DeleteCourse([FromRoute] int id)
        {
            _courseService.DeleteCourse(id);
            return Ok();
        }

        // roca gaarchev metyvi ro gavarchie, da daamateb yvela create da update model dto ebze validacias namebze ro ikos 2 simbolodan 50 simbolomde
        // course model/dto sheicavdes path id-s da update ebi shecavdes id-s, aseve nameze daadeb validacias ro shiedlzebodes mxolod qartuli asoebi
        // ok?ok
    }
}
