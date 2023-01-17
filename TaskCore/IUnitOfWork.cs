using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskCore.Interfaces;
using TaskCore.Models;

namespace TaskCore
{
    public interface IUnitOfWork : IDisposable
    {
        IBaseRepository<Task> Tasks { get; }
        IBaseRepository<Member> Members { get; }
        ITasksRepository TasksRepository { get; }

        int Complete();
    }
}
