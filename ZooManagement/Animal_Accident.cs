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
    
    public partial class Animal_Accident
    {
        public int Accident_ID { get; set; }
        public int Animal_ID { get; set; }
        public Nullable<System.DateTime> Start_day { get; set; }
        public Nullable<int> Reason_ID { get; set; }
        public Nullable<int> Fix_ID { get; set; }
        public Nullable<System.DateTime> End_day { get; set; }
    
        public virtual Accident Accident { get; set; }
        public virtual Animal Animal { get; set; }
        public virtual Fix Fix { get; set; }
        public virtual Reason Reason { get; set; }
    }
}
