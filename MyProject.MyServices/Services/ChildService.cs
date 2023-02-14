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
    public class ChildService : IChildService
    {
        private readonly IChildRepository _childRepository;
        private readonly IMapper _mapper;
        public ChildService(IChildRepository childRepository, IMapper mapper)
        {
            _childRepository = childRepository;
            _mapper = mapper;
        }
        public async Task<ChildDTO> AddAsync(ChildDTO child)
        {
            //var child2 = await GetByIdAsync(child.Identity);
            //if (child2 != null)
            //{
            //    child2.Parent2Id = child.Parent1Id;
            //    child2.Parent2 = child.Parent1;
            //    return await UpdateAsync(child2);
            //}

            return _mapper.Map<ChildDTO>(await _childRepository.AddAsync(_mapper.Map<Child>(child)));
        }
        public async Task DeleteAsync(string id)
        {
            await _childRepository.DeleteAsync(id);
        }
        public async Task<List<ChildDTO>> GetAllAsync()
        {
            return _mapper.Map<List<ChildDTO>>(await _childRepository.GetAllAsync());
        }
        public async Task<ChildDTO> GetByIdAsync(string id)
        {
            return _mapper.Map<ChildDTO>(await _childRepository.GetByIdAsync(id));
        }
        //public async Task<ChildDTO> GetByIdentityAsync(string identity)
        //{
        //    var children = await GetAllAsync();
        //    var child = children.Find((c) => { return c.Identity == identity; });
        //    return child;
        //}
        public async Task<ChildDTO> UpdateAsync(ChildDTO child)
        {
            return _mapper.Map<ChildDTO>(await _childRepository.UpdateAsync(_mapper.Map<Child>(child)));
        }
    }
}
