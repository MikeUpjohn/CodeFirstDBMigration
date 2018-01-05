using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_first_db_example
{
    public class MikeTestDBContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        public MikeTestDBContext()
            : base("name=MikeTestDBContext")
        {
#if DEBUG
            Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
            Configuration.ProxyCreationEnabled = false;
#endif
        }
    }
}
