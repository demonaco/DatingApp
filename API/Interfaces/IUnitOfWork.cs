using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Interfaces
{
    interface IUnitOfWork
    {
        IUserRepository UserRepository { get; set; }
        IMessageRepository MessageRepository { get; set; }
        ILikesRepository LikesRepository { get; set; }
        Task<bool> Complete();
        bool HasChanges();
    }
}
