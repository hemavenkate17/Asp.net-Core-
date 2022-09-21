using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManytoMany_Relationship.Model
{
    public class Skillmaps
    {
        public int employee_id { get; set; }
        public Employees Employees { get; set; }

        public int skillid { get; set; }
        public Skills Skills { get; set; }
    }
}
