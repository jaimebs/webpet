using System.Linq;
using Entity.Context;

namespace BLL.Usuario
{
    public class UsuarioBll : CrudGenerico<Entity.Models.Usuario>
    {
        public bool VerificarUsuario(Entity.Models.Usuario pEntity)
        {
            using (var context = new Context())
            {
                return context.Usuario.Any(c => c.Login == pEntity.Login && c.Senha == pEntity.Senha);
            }
        }
       
    }
}
