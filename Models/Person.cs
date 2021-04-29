using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TreinaWeb.TestAspNetMvc.Models
{
    public class Person
    {
        [Required]
        [DisplayName("Your name")]        
        public string Name { get; set; }
        [Required]
        [DisplayName("Your age")]
        public int Age { get; set; }
        [Required]
        [DisplayName("The city you live")]
        public string City { get; set; }
    }
}
