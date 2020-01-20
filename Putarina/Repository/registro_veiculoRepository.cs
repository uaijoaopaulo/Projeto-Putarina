using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Putarina.Model;

namespace Putarina.Repository
{
    class registro_veiculoRepository : RepositoryBase
    {
        public List<registro_veiculo> GetAll()
        {
            return DataModel.registro_veiculo.ToList();
        }
        public List<registro_veiculo> GetAll(DateTime datamin, DateTime datamax)
        {
            return DataModel.registro_veiculo.Where(e => e.horario >= datamin && e.horario <= datamax).ToList();
        }
        public List<registro_veiculo> GetAll(string forma)
        {
            return DataModel.registro_veiculo.Where(e =>  e.forma_pagamento.Contains(forma)).ToList();
        }
        public List<registro_veiculo> GetAll(DateTime datamin, DateTime datamax, string forma)
        {
            return DataModel.registro_veiculo.Where(e => e.horario >= datamin && e.horario <= datamax && e.forma_pagamento.Contains(forma)).ToList();
        }
        public void Salvar(registro_veiculo registroveiculo)
        {
            DataModel.Entry(registroveiculo).State = registroveiculo.id_usuario != 0 ?
                System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;
            DataModel.SaveChanges();
        }
    }
}
