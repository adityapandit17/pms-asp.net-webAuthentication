using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebTokenAuthentication.Models
{
    public class Task
    {
        [Key]
        public int TaskId { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public string Due_date { get; set; }
        public string status { get; set; }


        // Foreign key 
      
        public int ProjectId { get; set; }

        [ForeignKey("ProjectId")]
        public virtual Project Projects { get; set; }

    }
}