using Appcore.Interfaces;
using Appcore.Services;
using Autofac;
using Dominio;
using Infraestructura.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<ActivoFijoRepository>().As<IModel>();
            builder.RegisterType<ServiceRepository>().As<IService>();

            var container = builder.Build();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(container.Resolve(IService)));
        }
    }
}
