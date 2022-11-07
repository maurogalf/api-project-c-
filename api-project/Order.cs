using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_project
{
    internal class Order
    {
        public int Id { get; set; }
        public string Coments { get; set; }
        public Order ( int id, string coments)
        {
            this.Id = id;
            this.Coments = coments;
        }
    }
}
