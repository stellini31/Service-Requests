//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Service_Requests
{
    using System;
    using System.Collections.Generic;
    
    public partial class reminder
    {
        public int reminder_issue_id { get; set; }
        public int reminder_user_id { get; set; }
        public System.DateTime remider_date { get; set; }
        public bool reminder_enabled { get; set; }
    
        public virtual issue issue { get; set; }
        public virtual user user { get; set; }
    }
}