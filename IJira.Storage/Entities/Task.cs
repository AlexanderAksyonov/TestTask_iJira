using Jira.Storage.Avstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Jira.Storage.Entities
{
    public class JiraTask
    {
        [Key]
        public int TaskID { get; set; }

        public string Header { get; set; }

        public bool Complite { get; set; }
    }
}
