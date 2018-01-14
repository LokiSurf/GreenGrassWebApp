using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GreenGrassWebApp.Models
{
    public class TableHistoryRequest
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Team { get; set; }
        public string Manager { get; set; }
        public string TypeReguest { get; set; } // holiday, seek leave
        public string Date { get; set; }
        public string TakenDays { get; set; }
        public string TotalTakenDays { get; set; }
        public string TotalAvailableDays { get; set; }
        public string ReguestStatus { get; set; }
       
    }
}