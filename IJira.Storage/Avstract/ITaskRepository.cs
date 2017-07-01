using Jira.Storage.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jira.Storage.Avstract
{
    public interface ITaskRepository
    {
        IEnumerable<JiraTask> JiraTask { get; }
        void SaveTask(string header, bool complite);

        void CloseTasks(int id);

    }
}
