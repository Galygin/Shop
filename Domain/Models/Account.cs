using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Account : Boss
    {
        public string Mail { get; set; }
        public string Password { get; set; }
        public string Password1 { get; set; }
        public string Password2 { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
    }
}
