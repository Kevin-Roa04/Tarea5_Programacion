using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Interfaces
{
    public class ActivoFijoRepository : IModel
    {
        protected ActivoFijo[] Activos;
        public void Add(ActivoFijo activo, ref ActivoFijo[] Activos)
        {
            if (activo == null)
            {
                throw new ArgumentException(nameof(activo));
            }
            if (activo == null)
            {
                Activos = new ActivoFijo[1];
                Activos[0] = activo;
            }
            ActivoFijo[] tmp = new ActivoFijo[Activos.Length + 1];
            Array.Copy(Activos, tmp, Activos.Length);
            tmp[tmp.Length - 1] = activo;
            Activos = tmp;
        }

        public void Create(ActivoFijo activo)
        {
            Add(activo, ref Activos);
        }

        public ActivoFijo[] FindAll()
        {
            return Activos;
        }
    }
}
