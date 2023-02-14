using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.Common.DTOs;
using MyProject.MyServices.Interfaces;
using MyProject.WebAPI.Models;

namespace MyProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChildrenController : ControllerBase
    {
        private readonly IChildService _childService;

        public ChildrenController(IChildService childService)
        {
            _childService = childService;
        }

        [HttpGet]
        public async Task<List<ChildDTO>> Get()
        {
            return await _childService.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ChildDTO>> Get(string id)
        {
            var child = await _childService.GetByIdAsync(id);
           
            return child;
        }

       
        [HttpPost]
        public async Task<ActionResult<ChildDTO>> Post([FromBody] ChildModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return await _childService.AddAsync(new ChildDTO()
            {

                Identity = model.Identity,
                Name= model.Name,
                BirthDate = model.BirthDate,
                Parent1Id = model.Parent1Id,
                //Parent2Id = model.Parent2Id
            });

        }

       
        [HttpPut("{id}")]
        public async Task<ActionResult<ChildDTO>> Put(int id, [FromBody] ChildModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return await _childService.UpdateAsync(new ChildDTO()
            {
                Id = id,
                Identity = model.Identity,
                BirthDate = model.BirthDate,
                Name = model.Name,
                Parent1Id = model.Parent1Id,
                Parent2Id = model.Parent2Id
            }); 
        }


        [HttpDelete("{id}")]
        public async Task Delete(string id)
        {
            await _childService.DeleteAsync(id);
        }
    }
}
