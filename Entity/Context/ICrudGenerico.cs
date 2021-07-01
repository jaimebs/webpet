using System.Collections.Generic;

namespace Entity.Context
{
    public interface ICrudGenerico<T>
    {

        void Salvar(T entidade);
        void Editar(T entidade);
        void Excluir(T entidade);
        T RetornarPorId(int id);
        IList<T> RetornarTodos();
    }
}
