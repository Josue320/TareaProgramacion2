using AppCore.IServices;
using AppCore.Services;
using Autofac;
using Domain.Interfaces;
using Infraestructure.Repository;
using practicaDepreciacion.Presentaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicaDepreciacion
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           var builder = new ContainerBuilder();
            builder.RegisterType<BinaryActivoRepository>().As<IActivoModel>();
            builder.RegisterType<EmpleadoRepository>().As<IEmpleadoModel>();
            builder.RegisterType<ActivoServices>().As<IActivoServices>();
            builder.RegisterType<EmpleadoServices>().As<IEmpleadoService>();
            var container = builder.Build();
           
            Application.Run(new FrmEmpleados(container.Resolve<IEmpleadoService>()));
            //Application.Run(new Principal(container.Resolve<IActivoServices>()));


        }
    }
}
