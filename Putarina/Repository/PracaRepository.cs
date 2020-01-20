using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Putarina.Model;

namespace Putarina.Repository
{
    class PracaRepository : RepositoryBase
    {
        
        public void Salvar(praca Praca)
        {
            DataModel.Entry(Praca).State = Praca.id_praca == 0 ?
                System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;
            DataModel.SaveChanges(); 
        }
        public List<praca> GetAll()
        {
            return DataModel.praca.ToList();
        }
        public praca GetOne(int id)
        {
            try
            {
                return DataModel.praca.First(e => e.id_praca == id);
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }
        public void Delete(int id)
        {
            praca Praca = GetOne(id);
            DataModel.praca.Remove(Praca);
            DataModel.SaveChanges();
        }
    }
}
