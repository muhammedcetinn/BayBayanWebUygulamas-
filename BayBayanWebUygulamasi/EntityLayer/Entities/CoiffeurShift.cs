using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class CoiffeurShift
    {
        public int Id { get; set; }
        public int CoiffeurId { get; set; }
        [ForeignKey(nameof(CoiffeurId))]
        public Coiffeur Coiffeur { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public ICollection<PersonnelInfo> PersonnelInfos { get; set; }
    }
}
