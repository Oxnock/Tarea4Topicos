using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea4Topicos.Models
{
    public class Estacionamiento
    {
        public int EstacionamientoId { get; set; }
        public Vehiculo VehiculoId { get; set; }
        public Parqueo ParqueoId { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaSalida { get; set; }
        public int TarifaBasica { get; set; }
        public int Ganancia { get; set; }
        public int Mantenimiento { get; set; }
        public int ImpuestoVenta { get; set; }
        public int TotalAPagar { get; set; }
    }
}
