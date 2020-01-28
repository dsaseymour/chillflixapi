using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Chillflixapi.Models;
using Chillflixapi.Models.Repositories;
using Microsoft.Extensions.Logging;

namespace Chillflixapi.Controllers
{
    //https://www.notion.so/dannysas/Base-Controller-8adbe68ce13549cf904fee73939c32e4
    [Route("api/[controller]")]
    [ApiController]
    public abstract class MyBaseController<TCategoryName,TEntity, TRepository> : ControllerBase
        where TEntity : class, IEntity
        where TRepository : MyBaseRepository<TEntity>
    {
        private readonly TRepository _repository;
        private readonly ILogger<TCategoryName> _logger;

        public MyBaseController(TRepository repository, ILogger<TCategoryName> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        // GET: api/[controller]
        [HttpGet]
        public async virtual Task<ActionResult<IEnumerable<TEntity>>> Get()
        {
            _logger.LogError("Alvin and the Chipmunks");
            return await _repository.GetAll();
        }

        // GET: api/[controller]/5
        [HttpGet("{id}")]
        public async virtual Task<ActionResult<TEntity>> Get(int id)
        {
            var entity = await _repository.Get(id);
            if (entity == null)
            {
                return NotFound();
            }
            return entity;
        }

        // PUT: api/[controller]/5
        [HttpPut("{id}")]
        public async virtual Task<IActionResult> Put(int id, TEntity entity)
        {
            if (id != entity.Id)
            {
                return BadRequest();
            }
            await _repository.Update(entity);
            return NoContent();
        }

        // POST: api/[controller]
        [HttpPost]
        public async virtual Task<ActionResult<TEntity>> Post(TEntity entity)
        {
            await _repository.Add(entity);
            return CreatedAtAction("Get", new { id = entity.Id }, entity);
        }

        // DELETE: api/[controller]/5
        [HttpDelete("{id}")]
        public async virtual Task<ActionResult<TEntity>> Delete(int id)
        {
            var entity = await _repository.Delete(id);
            if (entity == null)
            {
                return NotFound();
            }
            return entity;
        }

    }


}
