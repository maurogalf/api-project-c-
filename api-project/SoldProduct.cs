﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_project
{
    internal class SoldProduct
    {
        public int Id { get; set; }
        public int IdProduct { get; set; }
        public int Stock { get; set; }
        public int IdOrder { get; set; }

    public SoldProduct (int id, int idProduct, int stock, int idOrder)
    {
        this.Id = id;
        this.IdProduct = idProduct;
        this.Stock = stock;
        this.IdOrder = idOrder;
    }
    }
}
