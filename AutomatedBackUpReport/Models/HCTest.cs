using System.ComponentModel.DataAnnotations;

namespace AutomatedBackUpReport.Models
{
    public class HCTest
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public string? Name { get; set; }
    }
}
