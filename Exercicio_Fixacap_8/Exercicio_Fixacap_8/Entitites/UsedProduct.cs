using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Fixacap_8.Entitites
{
    class UsedProduct : Product
    {
        public DateTime Manufacture { get; set; }

        public UsedProduct()
        {

        }

        public UsedProduct(string name, double price, DateTime manufacture): base(name, price)
        {
            Manufacture = manufacture;
        }

        public override string PriceTag()
        {
            return base.PriceTag()+"(Manufacture date: "+Manufacture.ToString("dd/MM/yyyy")  +")";
        }

    }
    
}
