using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Conference
{
    public class Schedule
    {
        [KEY]
        public int Id_Shedule { get; set; }
        public DateTime DataHour { get; set; }
        public string Host { get; set; }

    }
}