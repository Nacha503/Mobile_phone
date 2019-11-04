using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_phone
{
    public class GSM
    {
        string model, manufacturer, owner;
        double price;
        

        public string Model { get { return model; } set { model = value; } }
        public string Manufacturer { get { return manufacturer; } set { manufacturer = value; } }
        public string Owner { get { return owner; } set { owner = value; } }
        public double Price { get { return price; } set { price = value; } }

        
    }

}
