//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SurfBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Equipment
    {
        public int Equipment_id { get; set; }
    
        public virtual Hangar Hangar { get; set; }
        public virtual Rental Rental { get; set; }
    }
}
