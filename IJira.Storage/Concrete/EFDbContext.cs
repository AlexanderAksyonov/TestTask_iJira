using System.Data.Entity;
using Jira.Storage.Entities;
using System.Collections.Generic;

namespace Jira.Storage.Concrete
{
    class EFDbContext : DbContext
    {
        public DbSet<JiraTask> JiraTasks { get; set; }
    }
}
