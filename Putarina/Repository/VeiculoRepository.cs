using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Putarina.Model;

namespace Putarina.Repository
{
    class VeiculoRepository : RepositoryBase
    {
        public void Salvar(veiculo Veiculo)
        {
            DataModel.Entry(Veiculo).State = Veiculo.id_veiculo == 0 ?
                System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;
            DataModel.SaveChanges();
        }
        public veiculo GetOne(int id)
        {
            try
            {
                return DataModel.veiculo.First(e => e.id_veiculo == id);
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }
    }
}
