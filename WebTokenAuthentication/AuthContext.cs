using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using WebTokenAuthentication.Models;

namespace WebTokenAuthentication
{
    public class AuthContext : IdentityDbContext<IdentityUser>
    {

        public AuthContext()
            : base("AuthContext")
        {

        }

        //DbSet<Project> project { set; get; }
        //DbSet<Models.Task> task { set; get; }

        public System.Data.Entity.DbSet<WebTokenAuthentication.Models.Project> Projects { get; set; }

        public System.Data.Entity.DbSet<WebTokenAuthentication.Models.Task> Tasks { get; set; }
    }
}