using System.ComponentModel.DataAnnotations;
namespace EMR_Management_System.Models

{
    public class Doctor
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Specialization { get; set; }

        [Phone]
        public string PhoneNo { get; set; }

    }
}
