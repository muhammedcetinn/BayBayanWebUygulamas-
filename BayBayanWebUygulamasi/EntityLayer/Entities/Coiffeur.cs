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
    }
}
