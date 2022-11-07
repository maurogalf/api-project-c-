﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_project
{
    internal class Product
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set;  }
        public decimal SalePrice { get; set; }
        public int Stock { get; set; }
        public string IdUser { get; set; }

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
