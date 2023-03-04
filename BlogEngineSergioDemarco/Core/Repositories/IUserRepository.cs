using BlogEngineSergioDemarco.Areas.Identity.Data;

namespace BlogEngineSergioDemarco.Core.Repositories
{
    public interface IUserRepository
    {
        ICollection<ApplicationUser> GetUsers();

        ApplicationUser GetUser(string id);

        ApplicationUser UpdateUser(ApplicationUser user);
    }
}
