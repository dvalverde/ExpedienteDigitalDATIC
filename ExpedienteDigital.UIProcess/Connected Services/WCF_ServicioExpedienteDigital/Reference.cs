﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExpedienteDigital.UIProcess.WCF_ServicioExpedienteDigital {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WCF_ServicioExpedienteDigital.IServiciosExpedienteDigital")]
    public interface IServiciosExpedienteDigital {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosExpedienteDigital/ConsultarConfiguracion", ReplyAction="http://tempuri.org/IServiciosExpedienteDigital/ConsultarConfiguracionResponse")]
        ExpedienteDigital.Objetos.Clases.oRespuesta<System.Collections.Generic.List<ExpedienteDigital.Objetos.Clases.Configuracion>> ConsultarConfiguracion(System.Nullable<int> idConfiguracion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiciosExpedienteDigital/ConsultarConfiguracion", ReplyAction="http://tempuri.org/IServiciosExpedienteDigital/ConsultarConfiguracionResponse")]
        System.Threading.Tasks.Task<ExpedienteDigital.Objetos.Clases.oRespuesta<System.Collections.Generic.List<ExpedienteDigital.Objetos.Clases.Configuracion>>> ConsultarConfiguracionAsync(System.Nullable<int> idConfiguracion);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiciosExpedienteDigitalChannel : ExpedienteDigital.UIProcess.WCF_ServicioExpedienteDigital.IServiciosExpedienteDigital, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiciosExpedienteDigitalClient : System.ServiceModel.ClientBase<ExpedienteDigital.UIProcess.WCF_ServicioExpedienteDigital.IServiciosExpedienteDigital>, ExpedienteDigital.UIProcess.WCF_ServicioExpedienteDigital.IServiciosExpedienteDigital {
        
        public ServiciosExpedienteDigitalClient() {
        }
        
        public ServiciosExpedienteDigitalClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiciosExpedienteDigitalClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiciosExpedienteDigitalClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiciosExpedienteDigitalClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ExpedienteDigital.Objetos.Clases.oRespuesta<System.Collections.Generic.List<ExpedienteDigital.Objetos.Clases.Configuracion>> ConsultarConfiguracion(System.Nullable<int> idConfiguracion) {
            return base.Channel.ConsultarConfiguracion(idConfiguracion);
        }
        
        public System.Threading.Tasks.Task<ExpedienteDigital.Objetos.Clases.oRespuesta<System.Collections.Generic.List<ExpedienteDigital.Objetos.Clases.Configuracion>>> ConsultarConfiguracionAsync(System.Nullable<int> idConfiguracion) {
            return base.Channel.ConsultarConfiguracionAsync(idConfiguracion);
        }
    }
}
