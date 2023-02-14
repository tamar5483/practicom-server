using AutoMapper;
using MyProject.Common.DTOs;
using MyProject.MyServices.Interfaces;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.MyServices.Services
{
    public class UserService:IUserService
    {

        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public async Task<UserDTO> AddAsync(UserDTO user)
        {
            //var user2 = GetByIdAsync(user.Identity);
            //if(user==null)
           return _mapper.Map<UserDTO>(await _userRepository.AddAsync(_mapper.Map<User>(user)));
        //    else
        //    {
        //        user.Id = user2.Id;
        //        return await UpdateAsync(user);
        //    }
        }
        public async Task DeleteAsync(string id)
        {
            await _userRepository.DeleteAsync(id);
        }
        public async Task<List<UserDTO>> GetAllAsync()
        {
            return _mapper.Map<List<UserDTO>>(await _userRepository.GetAllAsync());
        }
        public async Task<UserDTO> GetByIdAsync(string id)
        {
            return _mapper.Map<UserDTO>(await _userRepository.GetByIdAsync(id));
        }
        public async Task<UserDTO> UpdateAsync(UserDTO user)
        {
            return _mapper.Map<UserDTO>(await _userRepository.UpdateAsync(_mapper.Map<User>(user)));
        }
    }
}
