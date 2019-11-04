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
        private double price;
        List<Call> llamadas = new List<Call>();
        

        public string Model { get { return model; } set { model = value; } }
        public string Manufacturer { get { return manufacturer; } set { manufacturer = value; } }
        public string Owner { get { return owner; } set { owner = value; } }
        public double Price { get { return price; } set { price = value; } }


        //metodos

       

        
    }

}
