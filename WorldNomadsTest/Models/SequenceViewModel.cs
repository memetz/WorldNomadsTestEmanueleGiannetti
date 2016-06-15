using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace WorldNomadsTest.Models
{
    public class SequenceViewModel
    {
        [Required(ErrorMessage = "{0} is required")]
        [RegularExpression("^\\d+$", ErrorMessage = "Must be a positive non decimal number")]
        public int Number { get; set; }
    }
}