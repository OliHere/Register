using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Register.Models
{
    public class EmpClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string MachineName { get; set; }
        [Required]
        public string MachineType { get; set; }
        [Required]
        public string HWKey { get; set; }
        [Required]
        public int CustomerID { get; set; }
        [Required]

        public string Location { get; set; }
        [Required]
        public DateTime ProductionDate { get; set; }

    }
}
