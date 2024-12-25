using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Appointment
    {
        [Key]
        public int Id { get; set; }
        public string CustomerId { get; set; }
        [ForeignKey(nameof(CustomerId))]
        public AppUser Customer { get; set; }
        public DateTime MeetDate { get; set; }
        public TimeSpan Start { get; set; }
        public int TotalDuration { get; set; }
        public decimal TotalPrice { get; set; }
        public ICollection<AppointmentDetail> AppointmentDetails { get; set; }
    }
}
