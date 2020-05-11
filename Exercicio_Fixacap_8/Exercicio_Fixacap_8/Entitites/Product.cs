﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Fixacap_8.Entitites
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        
        public Product()
        {

        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public virtual string PriceTag()
        {
            return Name + " $ " + Price;
        }
    }
}
