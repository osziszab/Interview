using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Entities
{
    [Table("Test")]
    public partial class Test
    {
        [Key]
        [StringLength(255)]
        public string AccountNumber { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SignupDate { get; set; }

        [StringLength(255)]
        public string SignupPlan { get; set; }

        [StringLength(255)]
        public string ClosedPlan { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ClosedDate { get; set; }
    }
}
