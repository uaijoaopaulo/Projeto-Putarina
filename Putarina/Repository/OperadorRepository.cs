using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Putarina.Model;

namespace Putarina.Repository 
{
    class OperadorRepository : RepositoryBase
    {
        public void Salvar(usuario Operador)
        {
            DataModel.Entry(Operador).State = Operador.id_usuario == 0 ?
                System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;
            DataModel.SaveChanges();
        }
        public List<usuario> GetAll()
        {
            return DataModel.usuario.ToList();
        }
        public usuario GetOne(int id)
        {
            try
            {
                return DataModel.usuario.First(e => e.id_usuario == id);
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }
        public usuario GetPS(string Usuario)
        {
            try
            {
                return DataModel.usuario.First(e => e.nickusuario == Usuario);
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }
        public void Delete(int id)
        {
            usuario operador = GetOne(id);
            DataModel.usuario.Remove(operador);
            DataModel.SaveChanges();
        }

    }
}
