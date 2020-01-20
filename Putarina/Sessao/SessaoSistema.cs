using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Putarina.Sessao
{
    public static class SessaoSistema
    {
        private static Int32 _usuarioId;
        private static Int32 _pracaUsuario;

        public static Int32 UsuarioId
        {
            get { return SessaoSistema._usuarioId; }
            set { SessaoSistema._usuarioId = value; }
        }
        public static Int32 PracaUsuario
        {
            get { return SessaoSistema._pracaUsuario; }
            set { SessaoSistema._pracaUsuario = value; }
        }
    }
    

}
