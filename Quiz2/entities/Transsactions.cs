using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2.entities
{
    public class Transsactions
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string SourceCardNumber { get; set; }
        [Required]
        public string DestinationCardNumber { get; set; }
        [Required]
        public float Amount { get; set; }
        [Required]
        public DateTime TransactionDate { get; set; }
        [Required]
        public bool isSuccessful { get; set; }
    }
}
