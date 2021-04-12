using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrywallProgram.Models
{
    public class NoteDetail
    {

        public int NoteId { get; set; }
        public String Title { get; set; }
        public String Content { get; set; }

        [Display(Name ="Created")]
        public DateTimeOffset CratedUtc { get; set; }
      
        [Display(Name="Modified")]
        public DateTimeOffset? ModifiedUtc { get; set; }



    }
}
