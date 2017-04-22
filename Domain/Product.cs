using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain
{
    public class Product : EntityBase
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public float Size { get; set; }
        public bool Removed { get; set; }
    }
}
