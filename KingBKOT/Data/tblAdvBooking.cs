//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KingBKOT.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblAdvBooking
    {
        public long id { get; set; }
        public string custName { get; set; }
        public string mob { get; set; }
        public Nullable<System.DateTime> eventDate { get; set; }
        public Nullable<System.DateTime> todayDate { get; set; }
        public Nullable<int> adults { get; set; }
        public Nullable<int> child { get; set; }
        public Nullable<decimal> advancePayment { get; set; }
        public Nullable<decimal> totalPayment { get; set; }
        public string status { get; set; }
        public Nullable<System.DateTime> cdate { get; set; }
        public Nullable<System.DateTime> udate { get; set; }
        public string recptNo { get; set; }
    }
}
