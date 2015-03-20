using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wireframe.Models
{
    public class IndexModel
    {
        [Required(ErrorMessage="Name is Required")]
        public String Name { get; set; }

        [Required(ErrorMessage = "Address is Required")]
        public String Address { get; set; }

        [Required(ErrorMessage = "City is Required")]
        public String City { get; set; }

        [Required(ErrorMessage = "Valid Email is Required")]
        [RegularExpression(@".*@.*")]
        public String Email { get; set; }

        [Required(ErrorMessage = "Message is Required")]
        public String Message { get; set; }
    }
}
