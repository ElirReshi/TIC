//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApplicationEF.Diagrama
{
    using System;
    using System.Collections.Generic;
    
    public partial class Examen
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Examen()
        {
            this.DetalleExamen = new HashSet<DetalleExamen>();
        }
    
        public int NumExamen { get; set; }
        public string CodResponsable { get; set; }
        public string TipoMantenimiento { get; set; }
        public string Justificacion { get; set; }
        public System.DateTime FechaReg { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleExamen> DetalleExamen { get; set; }
        public virtual Responsable Responsable { get; set; }
    }
}
