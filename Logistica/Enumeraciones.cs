using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistica
{
    internal class Enumeraciones
    {
        public enum EstadoVehiculo
        {
            Disponible,
            EnRuta,
            EnMantenimiento,
        }
        public enum TipoLicencia
        {
            A,
            B,
            C,
            D
        }
        public enum EstadoEntrega
        {
            Pendiente,
            EnTransito,
            Entregado,
            Cancelado
        }
    }
}
