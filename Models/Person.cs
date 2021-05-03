using Microsoft.AspNetCore.Mvc.ModelBinding;
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
        [Required(ErrorMessage = "Please, type your name, is required.")]
        [DisplayName("Your name")]
        [MaxLength(50, ErrorMessage = "The name can only be 50 characters long")]
        [MinLength(4, ErrorMessage = "The name must be at least 4 characters")]
        public string Name { get; set; }

        [DisplayName("Your age")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Please, type the city you live, is required.")]
        [DisplayName("The city you live")]
        [MaxLength(20, ErrorMessage = "The city name can only be 20 characters long")]
        [MinLength(4, ErrorMessage = "The city name must be at least 4 characters")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please, I need your email, it's a surprise . ( ͡° ͜ʖ ͡°)")]
        [DisplayName("Your email")]
        [MaxLength(30, ErrorMessage = "Your email can only be 30 characters long")]
        [MinLength(8, ErrorMessage = "The name must be at least 8 characters")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [BindNever]
        public bool Active { get; set; }
    }
}
