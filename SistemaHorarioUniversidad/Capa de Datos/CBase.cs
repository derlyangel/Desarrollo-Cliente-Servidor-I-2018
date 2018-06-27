using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Capa_de_Negocio;
namespace Capa_de_Datos
{
    public class CBase
    {
        private HorariosIEntities _contexto;
        public HorariosIEntities Contexto
        {
            get
            {
                if (_contexto == null)
                    _contexto = new HorariosIEntities();
                return _contexto;
            }
        }
    }
}
