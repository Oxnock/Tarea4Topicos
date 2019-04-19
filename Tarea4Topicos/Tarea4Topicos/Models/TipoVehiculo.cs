using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea4Topicos.Models
{
    public class TipoVehiculo
    {
       

        public int TipoVehiculoID { get; set; }
        public string Descripcion { get; set; }

       
        public ICollection<Vehiculo> ListaVehiculos { get; set; }
    }
}
