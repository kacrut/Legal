using System;
using System.Collections.Generic;

namespace Legal.Models
{
    public partial class vwSendEmail
    {
        public int ID { get; set; }
        public string KDKC { get; set; }
        public string NMKC { get; set; }
        public string PKSKD { get; set; }
        public string PKSNM { get; set; }
        public string NOMOR { get; set; }
        public int PKSKE { get; set; }
        public System.DateTime PKSTGLML { get; set; }
        public System.DateTime PKSTGLAKH { get; set; }
        public int KDCRBYR { get; set; }
        public Nullable<int> KDLAPSE { get; set; }
        public string MENUNAME { get; set; }
        public string KETERANGAN { get; set; }
        public Nullable<System.DateTime> CREATEDDATE { get; set; }
        public Nullable<int> MINGGU { get; set; }
        public int TAHUN { get; set; }
        public Nullable<int> BULAN { get; set; }
        public string email { get; set; }
    }
}
