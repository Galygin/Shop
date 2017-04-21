using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain
{
    public class Recall : EntityBase
    {
        public string Author { get; set; }
        public string Text { get; set; }
    }
}
