using BlogEngineSergioDemarco.Areas.Identity.Data;
using BlogEngineSergioDemarco.Core.Repositories;
using Microsoft.AspNetCore.Identity;

namespace BlogEngineSergioDemarco.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly ApplicationDbContext _context;

        public RoleRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public ICollection<IdentityRole> GetRoles()
        {
            return _context.Roles.ToList();
        }
    }
}
