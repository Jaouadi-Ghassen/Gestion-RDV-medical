using System.ComponentModel.DataAnnotations;

namespace Medical.Models
{
    public class Appointment
    {
        
        public int Id { get; set; }
        [Display(Name = "Appointment date")]
        public DateTime dateAp { get; set; }
        [Display(Name = "Nom de médecin")]
        public int DoctorId { get; set; }
        public virtual Doctor? Doctor { get; set; }
        [Display(Name = "Nom de patient")]
        public int PatientId { get; set; }
        public virtual Patient? Patient { get; set; }
    }

}
