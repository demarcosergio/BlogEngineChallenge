using BlogEngineSergioDemarco.Core.Repositories;

namespace BlogEngineSergioDemarco.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public IUserRepository User { get; }
        public IRoleRepository Role { get; }
        public IPostRepository Post { get; }

        public UnitOfWork(IUserRepository user, IRoleRepository role, IPostRepository post)
        {
            User = user;
            Role = role;
            Post = post;
        }
    }
}
