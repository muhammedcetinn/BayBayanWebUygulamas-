using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class PersonnelService : IEntityBase
    {
        public int Id { get; set; }
        public int CoiffeurServiceId { get; set; }
        [ForeignKey(nameof(CoiffeurServiceId))]
        public CoiffeurService CoiffeurService { get; set; }
        public string PersonnelId { get; set; }
        public Personnel Personnel { get; set; }
        public bool IsProf { get; set; }
        public decimal Price { get; set; }
        public int Duration { get; set; }
        public ICollection<AppointmentDetail> AppointmentDetails { get; set; }
    }
}
