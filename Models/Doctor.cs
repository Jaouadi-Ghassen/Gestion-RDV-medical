using System.ComponentModel.DataAnnotations;

namespace Medical.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        [Display(Name = "Nom de médecin")]
        public string Name { get; set; }
        [Display(Name = "Spécialité")]
        public string Specialty { get; set; }
        [Display(Name = "Contact information")]
        public string ContactInfo { get; set; }
        public virtual ICollection<Appointment>? Appointments { get; set; }
        public virtual ICollection<Prescription>? Prescriptions { get; set; }
    }

}
