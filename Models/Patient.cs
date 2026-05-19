using System.ComponentModel.DataAnnotations;

namespace EMR_Management_System.Models
{
    public class Patient
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Range(1, 120)]
        public int Age { get; set; }

        [Required]
        public string Gender { get; set; }

        [Phone]
        public string PhoneNo { get; set; }

        public string Blood_Type { get; set; }

        public string Address { get; set; }
    }
}