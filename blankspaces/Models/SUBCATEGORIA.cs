//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace blankspaces.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SUBCATEGORIA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SUBCATEGORIA()
        {
            this.MATERIALBIBLIOGRAFICOes = new HashSet<MATERIALBIBLIOGRAFICO>();
        }
    
        public string IDSUBCATEGORIA { get; set; }
        public string DESCRIPCION { get; set; }
        public string IDCATEGORIA { get; set; }
    
        public virtual CATERGORIA CATERGORIA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MATERIALBIBLIOGRAFICO> MATERIALBIBLIOGRAFICOes { get; set; }
    }
}
