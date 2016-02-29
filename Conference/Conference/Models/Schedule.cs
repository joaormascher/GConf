using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Conference.Models
{
    public class Schedule
    {
        [Key]
        public int Id_Shedule { get; set; }
        public DateTime DataHour { get; set; }
        public string Host { get; set; }
    }
}