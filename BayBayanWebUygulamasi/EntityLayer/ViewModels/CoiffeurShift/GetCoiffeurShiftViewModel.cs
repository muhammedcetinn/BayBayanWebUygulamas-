using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.ViewModels.CoiffeurShift
{
    public class GetCoiffeurShiftViewModel
    {
        public int Id { get; set; }
        public int CoiffeurId { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
    }
}
