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
    
    public partial class system_attachment
    {
        public long att_id { get; set; }
        public string name { get; set; }
        public string att_dir { get; set; }
        public string satt_dir { get; set; }
        public string att_size { get; set; }
        public string att_type { get; set; }
        public int pid { get; set; }
        public bool image_type { get; set; }
        public bool module_type { get; set; }
        public Nullable<decimal> uid { get; set; }
        public string invite_code { get; set; }
        public Nullable<System.DateTime> create_time { get; set; }
        public Nullable<System.DateTime> update_time { get; set; }
        public Nullable<bool> is_del { get; set; }
    }
}
