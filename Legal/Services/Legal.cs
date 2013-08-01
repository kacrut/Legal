using Legal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Legal.Services
{
    public class Legal : ILegal
    {
        public IEnumerable<BUEventLog> GetBUEventLogByCabang(string kdkc)
        {
            using (var db = new LegalMailerContext())
            {
                return db.BUEventLogs.Where(a => a.KDKC == kdkc).ToList();
            }
        }
    }
}