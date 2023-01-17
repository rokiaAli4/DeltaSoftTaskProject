using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskCore.Models;

namespace TaskCore.Interfaces
{
    public interface ITasksRepository : IBaseRepository<Task>
    {
        IEnumerable<Task> GetAllTasksWithMember();
    }
}
