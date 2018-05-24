using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebFormToMVC.Areas.MVCArea.Models
{
    public class WebFormToMVCContext : DbContext
    {

        public WebFormToMVCContext()
                : base("DefaultConnection") // "DefaultConnection" is from web.config file.
            {
                Database.SetInitializer<WebFormToMVCContext>(new DropCreateDatabaseIfModelChanges<WebFormToMVCContext>());
                // Above line is important otherwise when you make any change in the model, it will not work.

            }
        public DbSet<Employee> Employee { get; set; }

    }
}