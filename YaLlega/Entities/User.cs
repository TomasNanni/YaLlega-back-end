using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YaLlega.Entities
{
    internal class User
    {
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        public string lastName { get; set; }
        [Required]
        [EmailAddress]
        public string email { get; set; }
        [Required]
        public string password { get; set; }
        public string address { get; set; }
    };
}
