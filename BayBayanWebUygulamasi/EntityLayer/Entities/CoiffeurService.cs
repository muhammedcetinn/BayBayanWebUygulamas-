using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class CoiffeurService : IEntityBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CoiffeurId { get; set; }
        public Coiffeur Coiffeur { get; set; }
        public ICollection<PersonnelService> PersonnelServices { get; set; }
    }
}
