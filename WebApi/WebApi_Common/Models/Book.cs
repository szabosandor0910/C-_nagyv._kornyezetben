using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi_Common.Models
{
    public class Book
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required ]
        public Boolean Loaned { get; set; }

        public string? WhoLoan { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public override string ToString()
        {
            return $"{Title} - {WhoLoan} - {StartDate} - {EndDate}"  ;
        }


    }
}
