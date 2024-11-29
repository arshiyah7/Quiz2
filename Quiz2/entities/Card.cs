using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Quiz2.entities
{
    public class Card
    {
        [Key]
        public string CardNumber { get; set; }
        [Required]
        public string HoldersName { get; set; }
        [Required]
        public float Balance { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
