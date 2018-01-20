using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GreenGrassWebApp.Models
{
    public class Request
    {
        public string Id { get; set; }
        public string TypeReguest { get; set; } // holiday, seek leave
        public string Date { get; set; }
        public string TakenDays { get; set; }
    }
}
