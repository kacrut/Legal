using System;
using System.Collections.Generic;

namespace Legal.Models
{
    public partial class vwGetBUExpired
    {
        public string KDKC { get; set; }
        public string NMKC { get; set; }
        public string PKSKD { get; set; }
        public string PKSNM { get; set; }
        public string NOMOR { get; set; }
        public Nullable<decimal> PKSKE { get; set; }
        public Nullable<System.DateTime> PKSTGLML { get; set; }
        public Nullable<System.DateTime> PKSTGLAKH { get; set; }
        public string KDCRBYR { get; set; }
        public Nullable<int> KDLAPSE { get; set; }
        public string MENUNAME { get; set; }
        public string KETERANGAN { get; set; }
        public string EMAIL { get; set; }
        public System.DateTime CREATEDDATE { get; set; }
        public Nullable<int> MINGGU { get; set; }
        public Nullable<int> TAHUN { get; set; }
    }
}
