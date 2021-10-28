using Appcore.Services;
using Dominio;
using Infraestructura.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appcore.Interfaces
{
    public class ServiceRepository : IService
    {
        private IModel model;
        public void Add(ActivoFijo activo, ref ActivoFijo[] Activos)
        {
            model.Add(activo, ref Activos);
        }

        public void Create(ActivoFijo activo)
        {
            model.Create(activo);
        }

        public ActivoFijo[] FindAll()
        {
           return model.FindAll();
        }
    }
}
