using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GreenGrassWebApp.Models
{
    public class UserProfile
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Team { get; set; }
        public string Manager { get; set; }
        public string EmailManager { get; set; }
        public string EmailHR { get; set; }

    }
}