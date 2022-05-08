using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_CURD.Model
{
    public class paitent
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }

        public string diseasname { get; set; }
    }
}
