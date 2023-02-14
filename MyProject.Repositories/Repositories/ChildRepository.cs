using Microsoft.EntityFrameworkCore;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;


namespace MyProject.Repositories.Repositories
{
    public class ChildRepository : IChildRepository
    {
        private readonly IContext _context;

        public ChildRepository(IContext context)
        {
            this._context = context;
        }

        public async Task<List<Child>> GetAllAsync()
        {
            return await _context.Children.ToListAsync();
        }
        public async Task<Child> GetByIdAsync(string id)

        {
                return await _context.Children.Include(p => p.Parent1).Include(p => p.Parent2).FirstOrDefaultAsync(p => p.Identity == id);    
        }

        public async Task<Child> AddAsync(Child child)
        {
            _context.Children.Add(child);
            
                await _context.SaveChangesAsync();

            return child;
        }

        public async Task<Child> UpdateAsync(Child child)
        {
            var updateClaim = _context.Children.Update(child);
            await _context.SaveChangesAsync();
            return updateClaim.Entity;
        }

        public async Task DeleteAsync(string id)
        {
            Child child = await GetByIdAsync(id);
            _context.Children.Remove(child);
            await _context.SaveChangesAsync();
        }

    }
}
