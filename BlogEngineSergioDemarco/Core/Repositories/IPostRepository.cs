using BlogEngineSergioDemarco.Areas.Identity.Data;

namespace BlogEngineSergioDemarco.Core.Repositories
{
    public interface IPostRepository
    {
        ICollection<ApplicationPost> GetPosts();
    }
}
