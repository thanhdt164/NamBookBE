using DTT.BookStore.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DTT.BookStore.API.Controllers.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BaseEntityController<TEntity> : ControllerBase
    {
        #region Declare
        IBaseService<TEntity> _baseService;

        #endregion

        #region Constructor
        public BaseEntityController(IBaseService<TEntity> baseService)
        {
            _baseService = baseService;
        }
        #endregion

        #region Methods
        // GET: api/<BaseEntityController>
        [HttpGet]
        public IActionResult Get()
        {
            var entities = _baseService.GetAll();
            return Ok(entities);
        }

        // GET api/<BaseEntityController>/5
        [HttpGet("{id}")]   
        public IActionResult GetById(int id)
        {
            var entity = _baseService.GetById(id);
            return Ok(entity);
        }

        // POST api/<BaseEntityController>
        [HttpPost]
        public virtual IActionResult Insert([FromBody] TEntity entity)
        {
            var serviceResult = _baseService.Insert(entity);
            if (serviceResult.ResultCode == Core.Enum.DTTCode.NotValid)
            {
                return BadRequest(serviceResult);
            }
            else if (serviceResult.ResultCode == Core.Enum.DTTCode.Success)
            {
                return Ok(serviceResult);
            }
            else
            {
                return NoContent();
            }
        }

        // PUT api/<BaseEntityController>
        [HttpPut]
        public IActionResult Update([FromBody] TEntity entity)
        {
            var serviceResult = _baseService.Update(entity);
            if (serviceResult.ResultCode == Core.Enum.DTTCode.NotValid)
            {
                return BadRequest(serviceResult);
            }
            else if (serviceResult.ResultCode == Core.Enum.DTTCode.Success)
            {
                return Ok(serviceResult);
            }
            else
            {
                return NoContent();
            }
        }

        // DELETE api/<BaseEntityController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int entityId)
        {
            var serviceResult = _baseService.Delete(entityId);
            if (serviceResult.ResultCode == Core.Enum.DTTCode.NotValid)
            {
                return BadRequest(serviceResult);
            }
            else if (serviceResult.ResultCode == Core.Enum.DTTCode.Success)
            {
                return Ok(serviceResult);
            }
            else
            {
                return NoContent();
            }
        }

        // PUT api/<BaseEntityController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }


        #endregion
    }
}
