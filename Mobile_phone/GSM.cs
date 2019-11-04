using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_phone
{
    class GSM
    {
        string model, manufacturer, owner;
        private double price;
        List<Call> llamadas = new List<Call>();


        public string Model { get { return model; } set { model = value; } }
        public string Manufacturer { get { return manufacturer; } set { manufacturer = value; } }
        public string Owner { get { return owner; } set { owner = value; } }
        public double Price { get { return price; } set { price = value; } }


        //metodos
        /// <summary>
        /// Agregar una llamada a la lista de llamadas
        /// </summary>
        /// <param name="llamada" Value="La llamada a agregar"></param>
        public void AgregarLlamada(Call llamada)
        {
            llamadas.Add(llamada);
        }




        /// <summary>
        /// Imprime todas las llamadas realizadas
        /// </summary>
        public void ImprimirListaDeLlamadas()
        {

            foreach (Call item in llamadas)
            {
                Console.WriteLine(string.Format($"Fecha: {item.Fecha}\nInicio de llamada: {item.TimeOfStart}\nDuracion de llamada {item.DurationOfTheCall} "));
                Console.WriteLine(); ;
            }
        }

        public double FacturarLlamadas()
        {
            double subTotal = 0, duracion = 0;


            foreach (Call item in llamadas)
            {
                duracion += int.Parse(item.DurationOfTheCall.Replace("minutos", "").Trim());
            }

            return subTotal = duracion * Call.priceCall;
        }



    }

}
