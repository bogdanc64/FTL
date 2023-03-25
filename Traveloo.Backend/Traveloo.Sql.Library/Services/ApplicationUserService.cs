using Traveloo.Api.Core.Controllers;
using Traveloo.Sql.Library.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Traveloo.Sql.Library.Services
{
    public class ApplicationUserService : EntityServiceBase, IModelService<ApplicationUser>
    {
        public ApplicationUserService(DbContext context) : base(context) { }

        public ApplicationUser Create(ApplicationUser entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int entityId)
        {
            throw new NotImplementedException();
        }

        public ApplicationUser Get(int entityId)
        {
            throw new NotImplementedException();
        }

        public List<ApplicationUser> GetMany(Expression<Func<ApplicationUser, bool>>? filter = null)
        {
            if (filter != null)
            {
                return Context.ApplicationUsers.Where(filter).ToList();
            }
            else
            {
                return Context.ApplicationUsers.ToList();
            }
        }

        public ApplicationUser Update(ApplicationUser entity)
        {
            throw new NotImplementedException();
        }
    }
}
