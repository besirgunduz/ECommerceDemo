using ECommerceDemo.Business.Engines.Interfaces;
using ECommerceDemo.Core.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceDemo.App.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseController<TModel, TEntity> : Controller
        where TModel : BaseModel
        where TEntity : BaseEntity
    {
        private readonly IBaseService<TModel, TEntity> _baseService;
        public BaseController(IBaseService<TModel, TEntity> baseService)
        {
            _baseService = baseService;
        }

        [HttpGet("GetAll")]
        public virtual IActionResult GetAll()
        {
            var result = _baseService.GetAll();

            if (result.Success == true)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result.Message);
            }
        }

        [HttpGet("GetById")]
        public virtual IActionResult GetById(int id)
        {
            var result = _baseService.GetById(id);

            if (result.Success == true)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result.Message);
            }
        }
        [Authorize(Roles = "admin")]
        [HttpPost("Add")]
        public virtual IActionResult Add([FromBody] TModel model)
        {
            var result = _baseService.Add(model);
            if (result.Success == true)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result.Message);
            }

        }

        [HttpPost("Update")]
        public virtual IActionResult Update([FromBody] TModel model)
        {
            var result = _baseService.Update(model);
            if (result.Success == true)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result.Message);
            }
        }

        [HttpPost("Delete")]
        public virtual IActionResult Delete([FromBody] TModel model)
        {
            var result = _baseService.Delete(model);
            if (result.Success == true)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result.Message);
            }
        }

        [HttpPost("DeleteById")]
        public virtual IActionResult DeleteById(int id)
        {
            var result = _baseService.DeleteById(id);
            if (result.Success == true)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result.Message);
            }
        }
    }
}
