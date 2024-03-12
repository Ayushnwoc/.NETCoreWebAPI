using Microsoft.AspNetCore.Mvc;
using EntityAPI.Repositories;
using EntityAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using EntityAPI.Extensions;


namespace EntityAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EntityController : ControllerBase
    {
        private readonly IEntityRepository _entityRepository;

        public EntityController(IEntityRepository entityRepository)
        {
            _entityRepository = entityRepository ?? throw new ArgumentNullException(nameof(entityRepository));
        }

        [HttpGet]
        [HttpGet]
        public ActionResult<IEnumerable<Entity>> GetEntities([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10, [FromQuery] string sortBy = "Id", [FromQuery] string sortOrder = "asc")
        {
            var entities = _entityRepository.GetEntities();

            // Sorting
            if (!string.IsNullOrEmpty(sortBy))
            {
                entities = entities.OrderByProperty(sortBy, sortOrder);
            }

            // Pagination
            var totalCount = entities.Count();
            var totalPages = (int)Math.Ceiling((double)totalCount / pageSize);
            var results = entities.Skip((pageNumber - 1) * pageSize).Take(pageSize);

            return Ok(new { TotalCount = totalCount, TotalPages = totalPages, PageNumber = pageNumber, PageSize = pageSize, Results = results });
        }



        [HttpGet("{id}")]
        public ActionResult<Entity> GetEntityById(string id)
        {
            var entity = _entityRepository.GetEntityById(id);
            if (entity == null)
            {
                return NotFound();
            }
            return Ok(entity);
        }
    }
}
