using BlogEngineSergioDemarco.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;

namespace BlogEngineSergioDemarco.Core.Repositories
{
    public interface IRoleRepository
    {
        ICollection<IdentityRole> GetRoles();
    }
}
