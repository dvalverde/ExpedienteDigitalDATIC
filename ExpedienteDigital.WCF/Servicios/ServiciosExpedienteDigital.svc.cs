using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using ExpedienteDigital.Objetos;
using ExpedienteDigital.Objetos.Clases;
using ExpedienteDigital.Negocios.Clases;
using ExpedienteDigital.Utilitarios.Constantes;
using ExpedienteDigital.Utilitarios.Mensajes;
using System.Text.RegularExpressions;
using System.IO;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using RestSharp;
using System.Threading;
using System.Threading.Tasks;

namespace ExpedienteDigital.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiciosExpedienteDigital" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiciosExpedienteDigital.svc or ServiciosExpedienteDigital.svc.cs at the Solution Explorer and start debugging.
    public class ServiciosExpedienteDigital : IServiciosExpedienteDigital
    {

        #region Configuración
        public oRespuesta<List<Objetos.Clases.Configuracion>> ConsultarConfiguracion(int? idConfiguracion)
        {
            LnConfiguracion data = new LnConfiguracion();
            return data.ConsultarConfiguracion(idConfiguracion);
        }
        #endregion



    }
} 
