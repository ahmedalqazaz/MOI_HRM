using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MOI_HRM.Models
{
    public class HRM
    {
        [Key]
        public int ID { get; set; }
        public String FName { get; set; }
        public string rank { get; set; }
        public string study { get; set; }
        public string gender { get; set; }
        public String department { get; set; }
        public string StNumber { get; set; }
        





    }
}
