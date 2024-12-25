using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Coiffeur : IEntityBase
    {
        public int Id { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public ICollection<CoiffeurService> CoiffeurServices { get; set; }
        public ICollection<CoiffeurShift> CoiffeurShifts { get; set; }
    }
}
