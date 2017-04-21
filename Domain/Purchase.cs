using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain
{
    public class Purchase : EntityBase
    {
        public int ProductID { get; set; }
        public string AccountName { get; set; }
        public int Count { get; set; }
    }
}
