using Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ActivoFijo
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal ValorActivo { get; set; }
        public decimal ValorResidual { get; set; }
        public int VidaUtil { get; set; }
        public DateTime FechaAdquisicion;
        public TipoActivo TipoActivo { get; set; }
        public MetodosDepreciacion MetodosDepreciacion { get; set; } 

    }
}
