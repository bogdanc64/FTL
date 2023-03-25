using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Traveloo.Sql.Library.Services.Interfaces
{
    public interface IModelService<T>
    {
        public T Get(int entityId);
        public List<T> GetMany(Expression<Func<T, bool>>? filter = null);
        public T Create(T entity);
        public T Update(T entity);
        public bool Delete(int entityId);
    
            
    }
}
