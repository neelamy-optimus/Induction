//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Employee_Managment.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class loginDetail
    {
        public int id { get; set; }
        public string loginId { get; set; }
        public string password { get; set; }
        public string role { get; set; }
        public string status { get; set; }
        public Nullable<System.DateTime> lastLogin { get; set; }
        public Nullable<System.DateTime> created_date { get; set; }
        public string created_by { get; set; }
        public Nullable<System.DateTime> updated_date { get; set; }
        public string updated_by { get; set; }
    }
}
