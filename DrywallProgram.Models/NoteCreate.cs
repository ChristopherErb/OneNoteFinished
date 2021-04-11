using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrywallProgram.Models
{
    public class NoteCreate
    {

        [Required]
        [MinLength(2, ErrorMessage = "Please Enter at Least 2 Characters")]
        [MaxLength(100, ErrorMessage = "There are too many characters in this field")]
        public String Title { get; set; }


        [MaxLength(8000)]
        public String  Content { get; set; }
    }
}
