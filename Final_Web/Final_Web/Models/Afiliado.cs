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
    
    public partial class Afiliado
    {
        public int idAfiliado { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public Nullable<int> idSocio { get; set; }
    
        public virtual Socio Socio { get; set; }
    }
}
