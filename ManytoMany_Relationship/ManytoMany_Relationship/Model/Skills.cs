using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ManytoMany_Relationship.Model
{
    public class Skills
    {
        [Key]
        public int skillid { get; set; }
        public string name { get; set; }
       
        
        public ICollection<Skillmaps> Skillmaps { get; set; }
    }
}
