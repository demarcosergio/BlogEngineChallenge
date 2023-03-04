using BlogEngineSergioDemarco.Areas.Identity.Data;
using BlogEngineSergioDemarco.Core.Repositories;

namespace BlogEngineSergioDemarco.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly ApplicationDbContext _context;

        public PostRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public ICollection<ApplicationPost> GetPosts()
        {
            return _context.Posts.ToList();
        }
    }
}
