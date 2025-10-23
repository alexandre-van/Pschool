using Pschool.Models;
using Microsoft.EntityFrameworkCore;

namespace Pschool.Data.Services
{
    public class ParentsService : IParentsService
    {
        private readonly PschoolContext _context;
        public ParentsService(PschoolContext context)
        {
            _context = context;
        }

        public async Task Add(Parent parent)
        {
            _context.Parents.Add(parent);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Parent>> GetAll()
        {
            var parents = await _context.Parents.ToListAsync();
            return parents;
        }
    }
}