using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTask_2.Model
{
    internal class Order
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
