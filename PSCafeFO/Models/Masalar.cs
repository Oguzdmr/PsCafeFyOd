//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PSCafeFO.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Masalar
    {
        public int Id { get; set; }
        public string MasaTuru { get; set; }
        public Nullable<System.DateTime> AcilisSaat { get; set; }
        public Nullable<System.DateTime> KapanisSaat { get; set; }
        public Nullable<double> Fiyat { get; set; }
        public Nullable<bool> Durum { get; set; }
    }
}
