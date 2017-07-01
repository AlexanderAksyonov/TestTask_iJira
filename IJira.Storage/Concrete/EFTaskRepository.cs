using Jira.Storage.Avstract;
using Jira.Storage.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jira.Storage.Concrete
{
    public class EFTaskRepository : ITaskRepository
    {
        public IEnumerable<JiraTask> JiraTask
        {
            get 
            {
                using(EFDbContext context = new EFDbContext())
                {
                    return context.JiraTasks.ToList();
                }
            }
        }

        public void SaveTask(string header, bool complite)
        {
            JiraTask newTask = new JiraTask() { Header = header, Complite = complite, TaskID = 0 };
            using (EFDbContext context = new EFDbContext())
            {
                context.JiraTasks.Add(newTask);
                context.SaveChanges();
            }
        }

        public void CloseTasks (int id)
        {
            using (EFDbContext context = new EFDbContext())
            {
                JiraTask task = context.JiraTasks.Find(id);
                if (task!= null)
                { 
                    task.Complite = true;
                    context.SaveChanges();
                }
                
            }
        }
    }
}
