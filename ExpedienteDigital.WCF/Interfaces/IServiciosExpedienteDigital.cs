using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ExpedienteDigital.Objetos;
using ExpedienteDigital.Objetos.Clases;

namespace ExpedienteDigital.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiciosExpedienteDigital" in both code and config file together.
    [ServiceContract]
    public interface IServiciosExpedienteDigital
    {
        #region Configuración
        [OperationContract]
        oRespuesta<List<Objetos.Clases.Configuracion>> ConsultarConfiguracion(int? idConfiguracion);
        #endregion

    }
}
