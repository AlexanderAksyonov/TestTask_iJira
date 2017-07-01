using Jira.Storage.Avstract;
using Jira.Storage.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestTask_Jira.Models
{
    public class TaskModel
    {

        [DisplayName("Выбрать")]
        public bool Selected { get; set; }

        [HiddenInput(DisplayValue = false)]  
        public int TaskID { get; set; }

        [HiddenInput(DisplayValue = false)]
        public bool IsComplite { get; set; }

        [DisplayName("Заголовок")]
        public string Header{ get; set; }
    }
}