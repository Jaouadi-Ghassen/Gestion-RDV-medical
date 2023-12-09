using System.ComponentModel.DataAnnotations;

namespace Medical.Models
{
    public class Patient
    {
        public int Id { get; set; }
        [Display(Name = "Nom du patient")]
        public String Name { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date de naissance")]
        public DateTime date { get; set; }
        [Display(Name = "Contact information")]
        public string ContactInfo { get; set; }
        public virtual ICollection<Appointment>? Appointments { get; set; }
        public virtual ICollection<Prescription>? Prescriptions { get; set; }
    }
}
