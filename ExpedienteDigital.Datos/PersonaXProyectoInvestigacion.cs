//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExpedienteDigital.Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class PersonaXProyectoInvestigacion
    {
        public int ID { get; set; }
        public int id_persona { get; set; }
        public int id_proyecto_investigacion { get; set; }
    
        public virtual Persona Persona { get; set; }
        public virtual ProyectoInvestigacion ProyectoInvestigacion { get; set; }
    }
}
