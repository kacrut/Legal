using Legal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Legal.Services
{
    public interface ILegal
    {
        IEnumerable<BUEventLog> GetBUEventLogByCabang(string kdkc);
    }
}
