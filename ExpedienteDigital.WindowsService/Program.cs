using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace ExpedienteDigital.WindowsService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;

            ServicesToRun = new ServiceBase[]
            {
                new ExpedienteDigitalService()
            };
            ServiceBase.Run(ServicesToRun);

            //se ejecuta esta llamada cuando se desea probar el servicio de forma local
            //ExpedienteDigitalService service = new ExpedienteDigitalService();
            //service.timer1_Tick_prueba();

        }
    }
}
