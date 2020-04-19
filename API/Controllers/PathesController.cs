using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Course;
using Application.Path;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PathesController : ControllerBase
    {
        private readonly IPathService _pathService;
        private readonly IMapper _mapper;

        public PathesController(
            IPathService pathService,
            IMapper mapper)
        {
            _pathService = pathService;
            _mapper = mapper;
        }

        [HttpGet()]
        public ActionResult GetPathes()
        {
            return Ok(_pathService.GetPathes());
        }

        [HttpGet("{id}")]
        public ActionResult GetPath([FromRoute] int id)
        {
            return Ok(_pathService.GetPathDetails(id));
        }

        [HttpPost()]
        public ActionResult CreatePath([FromBody] CreatePathModel model)
        {
            var dto = _mapper.Map<CreatePathDto>(model);
            var id = _pathService.CreatePath(dto);
            return Ok(id);
        }

        [HttpPut("{id}")]
        public ActionResult UpdatePath([FromRoute] int id, UpdatePathModel request)
        {
            var dto = _mapper.Map<UpdatePathDto>(request);
            dto.Id = id;
            _pathService.UpdatePath(dto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult DeletePath([FromRoute] int id)
        {
            _pathService.DeletePath(id);
            return Ok();
        }

    }
}
