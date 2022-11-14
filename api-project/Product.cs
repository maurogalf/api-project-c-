using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_project
{
    public class Product
    {
        public int Id;
        public string Description;
        public decimal Cost;
        public decimal SalePrice;
        public int Stock;
        public string IdUser;

        public Product ( int id, string description, decimal cost, decimal salePrice, int stock, string idUser  )
        {
            this.Id = id;
            this.Description = description;
            this.Cost = cost;
            this.SalePrice = salePrice;
            this.Stock = stock;
            this.IdUser = idUser;
        }
    }
}
