//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mapper
{
    using System;
    using System.Collections.Generic;
    
    public partial class menu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public menu()
        {
            this.role = new HashSet<role>();
        }
    
        public long id { get; set; }
        public Nullable<bool> i_frame { get; set; }
        public string name { get; set; }
        public string component { get; set; }
        public long pid { get; set; }
        public long sort { get; set; }
        public string icon { get; set; }
        public string path { get; set; }
        public Nullable<bool> cache { get; set; }
        public Nullable<bool> hidden { get; set; }
        public string component_name { get; set; }
        public Nullable<System.DateTime> create_time { get; set; }
        public string permission { get; set; }
        public Nullable<int> type { get; set; }
        public Nullable<System.DateTime> update_time { get; set; }
        public Nullable<bool> is_del { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<role> role { get; set; }
    }
}
