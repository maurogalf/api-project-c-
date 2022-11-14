using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_project
{
    public class Order
    {
        public int Id;
        public string Coments;
        public Order ( int id, string coments)
        {
            this.Id = id;
            this.Coments = coments;
        }
    }
}
