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
    
    public partial class MembresiaConsejos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MembresiaConsejos()
        {
            this.DocumentoMembresiaConsejos = new HashSet<DocumentoMembresiaConsejos>();
            this.PersonaXMembresiaConsejos = new HashSet<PersonaXMembresiaConsejos>();
        }
    
        public int ID { get; set; }
        public string nombre { get; set; }
        public int tipo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentoMembresiaConsejos> DocumentoMembresiaConsejos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonaXMembresiaConsejos> PersonaXMembresiaConsejos { get; set; }
    }
}
