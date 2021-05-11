using Microsoft.AspNetCore.Mvc;
using MISA.Core.Enum;
using MISA.Core.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MISA.CukCuk.WebAPIs.Controllers
{
    [Route("api/v1/[controller]s")]
    [ApiController]
    public abstract class BaseEntityController<T> : ControllerBase
    {
        IBaseService<T> _baseService;
        public BaseEntityController(IBaseService<T> baseService)
        {
            _baseService = baseService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var entities = _baseService.Get();
            return Ok(entities);
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var entity = _baseService.GetById(id);
            return Ok(entity);
        }

        [HttpPost]
        public IActionResult Post(T entity)
        {
            var row = _baseService.Insert(entity);
            return Ok(row);
        }

        [HttpPut("{id}")]
        public IActionResult Put(T entity, Guid id)
        {
            var row = _baseService.Update(entity);
            return Ok(row);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var res = _baseService.Delete(id);
            return Ok(res);
        }
    }
}
