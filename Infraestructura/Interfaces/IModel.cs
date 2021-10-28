using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Interfaces
{
    public interface IModel
    {
        void Create(ActivoFijo activo);
        void Add(ActivoFijo activo, ref ActivoFijo[] activos);
        ActivoFijo[] FindAll();
    }
}
