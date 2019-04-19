using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea4Topicos.Models
{
    public class Vehiculo
    {
        public int VehiculoId { get; set; }
        public TipoVehiculo TipoVehiculoRef { get; set; }
        public int Placa { get; set; }
        public int Anio { get; set; }

        
        
    }
}
