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
    
    public partial class Trainer
    {
        public int Trainer_id { get; set; }
    
        public virtual School School { get; set; }
        public virtual Schedule Schedule { get; set; }
        public virtual Client Client { get; set; }
    }
}
