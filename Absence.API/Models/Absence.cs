using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Absence.API.Models
{
    public class Absence
    {
        public int AbsenceRequestID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}