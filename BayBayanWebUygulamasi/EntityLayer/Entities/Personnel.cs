using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Personnel
    {
        [Key,ForeignKey("AppUser")]
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public string FullName { get; set; }
        public ICollection<PersonnelInfo> PersonnelInfos { get; set; }
        public ICollection<PersonnelService> PersonnelServices { get; set; }
    }
}
