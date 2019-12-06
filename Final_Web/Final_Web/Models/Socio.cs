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
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellidos { get; set; }
        [Required]
        public string Cedula { get; set; }
        [Required]
        public string Foto { get; set; }
        [Required]
        public string Direccion { get; set; }
        [Required]
        public string Sexo { get; set; }
        [Required]
        public string Edad { get; set; }
        [Required]
        public Nullable<System.DateTime> FechaNacimiento { get; set; }
        [Required] 
        public string TipoMembresia { get; set; }
        [Required]
        public string LugarTrabajo { get; set; }
        [Required]
        public string DireccionTrabajo { get; set; }
        [Required]
        public string TelefonoOficina { get; set; }
        [Required]
        public string EstadoMembresia { get; set; }
        [Required]
        public Nullable<System.DateTime> FechaIngreso { get; set; }
        [Required]
        public Nullable<System.DateTime> FechaSalida { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Afiliado> Afiliados { get; set; }
    }
}