using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_CURD.Model
{
    public class OrderDemo
    {
        [Key]
        public int OrderId { get; set; }
        public string OrderDetails { get; set; }
        public bool IsActive { get; set; }
        public DateTime OrderedDate { get; set; }
    }
}
