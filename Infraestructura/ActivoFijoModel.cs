using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura
{
    public class ActivoFijoModel
    {
        ActivoFijo[] Activo;

        public void Add(ActivoFijo activoFijo)
        {
            if (activoFijo == null)
            {
                throw new ArgumentException(nameof(activoFijo));
            }
            if (Activo == null)
            {
                Activo = new ActivoFijo[1];
                Activo[0] = activoFijo;
            }
            ActivoFijo[] tmp = new ActivoFijo[Activo.Length + 1];
            Array.Copy(Activo, tmp, Activo.Length);
            tmp[tmp.Length - 1] = activoFijo;
            Activo = tmp;

        }

        public decimal MetodoLineal(decimal ValorActivo, int VidaUtil, decimal ValorResidual)
        {
            decimal amortizacion;
            return amortizacion = (ValorActivo - ValorResidual) / VidaUtil;
        }

        public decimal[] MetodoSaldoDecreciente(decimal ValorActivo, decimal ValorResidual, int VidaUtil)
        {
            decimal[] ValorAnual = new decimal[VidaUtil];
            int Sumatoria = 0;
            int a = 1;
            for (int i = 0; i < VidaUtil; i++)
            {
                Sumatoria += a;
                a++;
            }
            int indice = 0;
            for (a = VidaUtil; a == 0; a--)
            {
                ValorAnual[indice] = ((VidaUtil / Sumatoria) * (ValorActivo - ValorResidual));
                indice++;
            }
            return ValorAnual;
        }
    }
}
