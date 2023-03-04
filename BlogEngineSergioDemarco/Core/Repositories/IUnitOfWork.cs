﻿namespace BlogEngineSergioDemarco.Core.Repositories
{
    public interface IUnitOfWork
    {
        IUserRepository User { get; }

        IRoleRepository Role { get; }
        IPostRepository Post { get; }
    }
}
