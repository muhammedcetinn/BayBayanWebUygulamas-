using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class PersonnelInfo
    {
        public int Id { get; set; }
        public string PersonnelId { get; set; }
        [ForeignKey(nameof(PersonnelId))]
        public Personnel Personnel { get; set; }
        public DayOfWeek WorkDay { get; set; }
        public int CoiffeurShiftId { get; set; }
        [ForeignKey(nameof(CoiffeurShiftId))]
        public CoiffeurShift CoiffeurShift { get; set; }

    }
}
