using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_CURD.Model
{
    public class ProductDemo
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public bool isDisCountApplied { get; set; }
    }
}
