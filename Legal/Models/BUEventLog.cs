using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Legal.Models
{
    public partial class BUEventLog
    {
        public int ID { get; set; }
        public string KDKC { get; set; }
        public string NMKC { get; set; }
        public string PKSKD { get; set; }
        public string PKSNM { get; set; }
        public string NOMOR { get; set; }
        public int PKSKE { get; set; }
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public System.DateTime PKSTGLML { get; set; }
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public System.DateTime PKSTGLAKH { get; set; }
        public int KDCRBYR { get; set; }
        public Nullable<int> KDLAPSE { get; set; }
        public string MENUNAME { get; set; }
        public string KETERANGAN { get; set; }
        public System.DateTime CREATEDDATE { get; set; }
        public Nullable<System.DateTime> MODIFIEDDATE { get; set; }
        public int MINGGU { get; set; }
        public int TAHUN { get; set; }
    }
}
