using System.Collections.Generic;
using Dio.Series.Interfaces;
namespace Dio.Series
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSeries = new List<Serie>();
        public void Atualiza(int ID, Serie entidade)
        {
            listaSeries[ID] = entidade;
        }

        public void Excluir(int ID)
        {
            listaSeries[ID].Exclui();
        }

        public void Insert(Serie entidade)
        {
            listaSeries.Add(entidade);
        }

        public List<Serie> Lista()
        {
            return listaSeries;
        }

        public int ProximoID()
        {
            return listaSeries.Count;
        }

        public Serie RetornaPorID(int ID)
        {
            return listaSeries[ID];
        }
     
    }
}