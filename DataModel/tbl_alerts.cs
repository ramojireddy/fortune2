//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FortuneTechPvtLtd.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_alerts
    {
        public int alert_Id { get; set; }
        public int alert_mast_Id { get; set; }
        public string alert_mast__name { get; set; }
        public string alert_Category { get; set; }
        public string alert_type { get; set; }
        public string alert_product { get; set; }
        public string alert_status { get; set; }
        public string alert_comments { get; set; }
        public int compId { get; set; }
        public int brId { get; set; }
        public string alert_flag { get; set; }
        public Nullable<int> alert_flagid { get; set; }
    }
}
