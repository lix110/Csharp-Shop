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
    
    public partial class store_coupon_user
    {
        public long id { get; set; }
        public long cid { get; set; }
        public decimal uid { get; set; }
        public string coupon_title { get; set; }
        public System.DateTime create_time { get; set; }
        public Nullable<System.DateTime> update_time { get; set; }
        public System.DateTime end_time { get; set; }
        public Nullable<System.DateTime> use_time { get; set; }
        public string type { get; set; }
        public bool status { get; set; }
        public bool is_fail { get; set; }
        public Nullable<bool> is_del { get; set; }
    }
}
