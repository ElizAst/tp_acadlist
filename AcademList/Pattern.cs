//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AcademList
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pattern
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pattern()
        {
            this.AcadList = new HashSet<AcadList>();
        }
    
        public int Id { get; set; }
        public int Number { get; set; }
        public string Semester { get; set; }
        public string Professor_Id { get; set; }
        public int Subject_Id { get; set; }
        public int Group_Id { get; set; }
        public string Status { get; set; }
    
        public virtual AspNetUsers AspNetUsers { get; set; }
        public virtual Groups Groups { get; set; }
        public virtual Subject Subject { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AcadList> AcadList { get; set; }
    }
}
