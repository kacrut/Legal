using System;
using System.Collections.Generic;

namespace Legal.Models
{
    public partial class LegalEventLog
    {
        public int ID { get; set; }
        public string KDKC { get; set; }
        public string NMKC { get; set; }
        public string PKSKD { get; set; }
        public string PKSNM { get; set; }
        public string NOMOR { get; set; }
        public System.DateTime PKSTGLML { get; set; }
        public System.DateTime PKSTGLAKH { get; set; }
        public string KDCRBYR { get; set; }
        public Nullable<int> KDLAPSE { get; set; }
        public string MENUNAME { get; set; }
        public string KETERANGAN { get; set; }
        public string Email { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string Notes { get; set; }
        public bool Status { get; set; }
    }
}
