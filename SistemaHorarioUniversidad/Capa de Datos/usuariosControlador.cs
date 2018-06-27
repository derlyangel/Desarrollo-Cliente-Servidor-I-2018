using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Capa_de_Negocio;
namespace Capa_de_Datos
{
    public class usuariosControlador : CBase
    {
        public usuario VerificarUsuario(string prmUsuario, string prmContraseña)
        {

            var verificar =
                (from t in Contexto.usuario
                 where t.id == prmUsuario && t.contraseña == prmContraseña
                 select t);

            return verificar.FirstOrDefault();

        }
    }
}
