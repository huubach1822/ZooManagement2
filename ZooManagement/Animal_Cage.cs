//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZooManagement
{
    using System;
    using System.Collections.Generic;
    
    public partial class Animal_Cage
    {
        public int Cage_ID { get; set; }
        public int Animal_ID { get; set; }
        public Nullable<System.DateTime> Day_in { get; set; }
        public string Reason_in { get; set; }
    
        public virtual Animal Animal { get; set; }
        public virtual Cage Cage { get; set; }
    }
}
