using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskCore.Interfaces;
using TaskCore.Models;

namespace TaskEF.Repositories
{
    public class TasksRepository : BaseRepository<Task>, ITasksRepository
    {
        private readonly ApplicationDbContext _context;
        public TasksRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public IEnumerable<Task> GetAllTasksWithMember()
        {
            return _context.Tasks.Include("Member");
        }
    }
}
