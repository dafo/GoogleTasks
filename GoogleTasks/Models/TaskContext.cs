﻿using Microsoft.EntityFrameworkCore;

namespace GoogleTasks.Models
{
    public class TaskContext: DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options): base(options) { }
        public DbSet<Task> Tasks { get; set; } = null;
    }
}
