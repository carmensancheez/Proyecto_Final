//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Final_Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Socio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Socio()
        {
            this.Afiliados = new HashSet<Afiliado>();
        }
    
        public int Id { get; set; }
      
        public string Nombre { get; set; }
     
        public string Apellidos { get; set; }
       
        public string Cedula { get; set; }
    
        public string Foto { get; set; }
     
        public string Direccion { get; set; }
      
        public string Sexo { get; set; }
        
        public string Edad { get; set; }
        
        public Nullable<System.DateTime> FechaNacimiento { get; set; }
   
        public string TipoMembresia { get; set; }
    
        public string LugarTrabajo { get; set; }
 
        public string DireccionTrabajo { get; set; }
      
        public string TelefonoOficina { get; set; }
 
        public string EstadoMembresia { get; set; }
    
        public Nullable<System.DateTime> FechaIngreso { get; set; }

        public Nullable<System.DateTime> FechaSalida { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Afiliado> Afiliados { get; set; }
    }
}
