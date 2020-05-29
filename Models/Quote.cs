using System;
using System.ComponentModel.DataAnnotations;

namespace QuotesWebAPI.Models
{
    public class Quote
    {
        [Required(ErrorMessage = "Id can't be empty")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Text can't be empty")]
        public string Text { get; set; }
        public string Author { get; set; }
        [Required(ErrorMessage = "InsertDate can't be empty")]
        public DateTime InsertDate { get; set; }
    }
}