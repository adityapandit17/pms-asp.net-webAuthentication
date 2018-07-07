using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebTokenAuthentication.Models
{
    public class Project
    {
        [Key]
        public int ProjectId { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public string Due_date { set; get; }
        public string status { set; get; } 
    }
}