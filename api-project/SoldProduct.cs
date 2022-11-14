using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_project
{
    public class SoldProduct
    {
        public int Id;
        public int IdProduct;
        public int Stock;
        public int IdOrder;

    public SoldProduct (int id, int idProduct, int stock, int idOrder)
    {
        this.Id = id;
        this.IdProduct = idProduct;
        this.Stock = stock;
        this.IdOrder = idOrder;
    }
    }
}
