//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Deanery
{
    using System;
    using System.Collections.Generic;
    
    public partial class SubjectSet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SubjectSet()
        {
            this.PointSet = new HashSet<PointSet>();
        }
    
        public int id { get; set; }
        public string NameSubject { get; set; }
        public string Teacher { get; set; }
        public Nullable<int> Semester { get; set; }
        public Nullable<int> Year { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PointSet> PointSet { get; set; }
    }
}
