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
    
    public partial class PointSet
    {
        public int id { get; set; }
        public int idSubject { get; set; }
        public int idStudent { get; set; }
        public Nullable<int> Point { get; set; }
    
        public virtual StudentSet StudentSet { get; set; }
        public virtual SubjectSet SubjectSet { get; set; }
    }
}