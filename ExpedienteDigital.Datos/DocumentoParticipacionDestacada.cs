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
    
    public partial class DocumentoParticipacionDestacada
    {
        public int ID { get; set; }
        public System.Guid FileID { get; set; }
        public string FileName { get; set; }
        public byte[] FileStreamCol { get; set; }
        public int id_participacion { get; set; }
    
        public virtual ParticipacionDestacada ParticipacionDestacada { get; set; }
    }
}
