using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveloo.Sql.Library.Services
{
    public class EntityServiceBase
    {
        public DbContext Context { get; set; }
        public EntityServiceBase(DbContext context)
        {
            Context = context;
        }
    }
}
