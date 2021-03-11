using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VisitorManagementSystem.Models
{
    public class StaffNames
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        public String Department { get; set; }
        public int VisitorCount { get; set; }
    }
}
