using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ExpedienteDigital.Objetos.Clases;
using ExpedienteDigital.Utilitarios.Clases;
using ExpedienteDigital.Utilitarios.Constantes;
using ExpedienteDigital.Utilitarios.Mensajes;
using ExpedienteDigital.Datos.Clases;
using AutoMapper;
using ExpedienteDigital.Datos;
using System.Configuration;

namespace ExpedienteDigital.Negocios.Clases
{
    public class LnConfiguracion
    {
        #region Variables y Constantes

        AdConfiguracion accesoDatos = new AdConfiguracion();

        #endregion

        #region Métodos

        #region Consultar

        public oRespuesta<List<Objetos.Clases.Configuracion>> ConsultarConfiguracion(int? idConfiguracion)
        {
            //Definición de la respuesta a brindar
            oRespuesta<List<Objetos.Clases.Configuracion>> respuesta = new oRespuesta<List<Objetos.Clases.Configuracion>>();

            try
            {
                #region Validaciones de parámetros de entrada

                if (idConfiguracion <= 0)
                {
                    //Asignación de código de respuesta y descripción
                    respuesta.CodigoRespuesta = Constantes.Respuesta.CODIGOERROR;
                    respuesta.MensajeRespuesta = Mensajes.ExpedienteDigital_Parametros_invalidos;
                    return respuesta;
                }
               


                #endregion

                //Configuración de Mapeo
                var config =
                    new MapperConfiguration(cfg => cfg.CreateMap<pr_ObtieneConfiguracion_Result, Objetos.Clases.Configuracion>());
                var mapper = config.CreateMapper();

                #region Obtener de Datos

                //Solicitud Acceso Datos 
                var respuestaAd = accesoDatos.ConsultarConfiguracion(idConfiguracion);

                //Validación de Éxito
                if (respuestaAd.Item2 == Constantes.Respuesta.CODIGOERROR)
                {
                    respuesta.CodigoRespuesta = Convert.ToInt32(Constantes.Respuesta.CODIGOERROR);
                    respuesta.MensajeRespuesta = Mensajes.MensajeGenerico;
                    respuesta.Estado = false;
                    return respuesta;
                }

                //Mapeo de la respuesta
                List<pr_ObtieneConfiguracion_Result> listaObtenida = respuestaAd.Item1;

                #endregion

                //Mapeo de los objetos
                List<Objetos.Clases.Configuracion> listaObjetos =
                    mapper.Map<List<pr_ObtieneConfiguracion_Result>, List<Objetos.Clases.Configuracion>>(listaObtenida);

                //Respuesta Exitosa
                //SET del mensaje a devolver
                respuesta.CodigoRespuesta = Convert.ToInt32(Constantes.Respuesta.CODIGOEXITO);
                respuesta.MensajeRespuesta = string.Empty;
                respuesta.ObjetoRespuesta = listaObjetos;
                respuesta.Estado = true;

            }
            catch
            {
                respuesta.CodigoRespuesta = Convert.ToInt32(Constantes.Respuesta.CODIGOERROR);
                respuesta.MensajeRespuesta = Mensajes.MensajeGenerico;
                respuesta.Estado = false;
            }

            return respuesta;
        }

        #endregion

        #endregion
    }
}
