using System.Collections.Generic;
namespace Dio.Series.Interfaces
{
    public interface IRepositorio<T>
    {
         List<T> Lista();
         T RetornaPorID(int ID);
         void Insert(T entidade);
         void Excluir(int ID);
         void Atualiza(int ID, T entidade);
         int ProximoID();
    }
}