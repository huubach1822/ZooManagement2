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
    
    public partial class Cage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cage()
        {
            this.Animal_Cage = new HashSet<Animal_Cage>();
        }
    
        public int ID { get; set; }
        public Nullable<int> Species_ID { get; set; }
        public Nullable<int> Area_ID { get; set; }
        public Nullable<int> Cage_area { get; set; }
        public Nullable<int> Height { get; set; }
        public Nullable<int> Capacity { get; set; }
        public Nullable<int> Condition_ID { get; set; }
        public Nullable<int> Employee_ID { get; set; }
        public string Note { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Animal_Cage> Animal_Cage { get; set; }
        public virtual Area Area { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Condition Condition { get; set; }
        public virtual Species Species { get; set; }
    }
}
