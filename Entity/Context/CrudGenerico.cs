using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Entity.Context
{
    public class CrudGenerico<T> : ICrudGenerico<T> where T : class
    {
         public void Salvar(T entidade)
        {
            using (var context = new Context())
            {
                context.Set<T>().Add(entidade);
                context.SaveChanges();
            }
        }

        public void Editar(T entidade)
        {
            using (var context = new Context())
            {
                context.Entry(entidade).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Excluir(T entidade)
        {
            using (var context = new Context())
            {
                context.Set<T>().Remove(entidade);
                context.SaveChanges();
            }
        }

        public T RetornarPorId(int id)
        {
            using (var context = new Context())
            {
                return context.Set<T>().Find(id);
            }
        }

        public IList<T> RetornarTodos()
        {
            using (var context = new Context())
            {
                return context.Set<T>().ToList();
            }
        }
    }
    
}
