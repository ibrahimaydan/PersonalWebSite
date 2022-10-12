using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KisiselWebSitesi.Models
{
    public class Icons
    {
        [Key]
        public int Id { get; set; }
        public string IconName { get; set; }
        public string link { get; set; }

    }
}