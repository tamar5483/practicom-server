using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.Common.DTOs;
using MyProject.MyServices.Interfaces;
using MyProject.Repositories.Entities;
using MyProject.WebAPI.Models;

namespace MyProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<List<UserDTO>> Get()
        {
            return await _userService.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserDTO>> Get(string id)
        {
            var user = await _userService.GetByIdAsync(id);
            if (user is null)
            {
                return NotFound();
            }
            return user;
        }

        [HttpPost]
        public async Task<ActionResult<UserDTO>> Post([FromBody] UserModel model)
        {
            int number; int.TryParse(model.Gender, out number);

            int number2; int.TryParse(model.HMO, out number2);
           
            return await _userService.AddAsync(new UserDTO()
            {
                Identity = model.Identity,
                FirstName = model.FirstName,
                LastName = model.LastName,
                BirthDate = model.BirthDate,
                Gender = (EGender)number,
                HMO = (EHMO)number2
            });


        }

        [HttpPut("{id}")]
        public async Task<ActionResult<UserDTO>> Put(int id, [FromBody] UserModel model)
        {
            int number2; int.TryParse(model.HMO, out number2);
            int number; int.TryParse(model.Gender, out number);
           
            return await _userService.UpdateAsync(new UserDTO()
            {
                Id = id,
                Identity = model.Identity,
                FirstName = model.FirstName,
                LastName = model.LastName,
                BirthDate = model.BirthDate,
                Gender = (EGender)number,
                HMO = (EHMO)number2

            });
        }


        [HttpDelete("{id}")]
        public async Task Delete(string id)
        {
            await _userService.DeleteAsync(id);
        }
    }
}
