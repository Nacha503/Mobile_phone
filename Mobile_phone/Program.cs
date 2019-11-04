using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_phone
{
    class Program
    {
        //Define a class, which contains information about a mobile phone:
        //model, manufacturer, price, owner, features of the battery(model, idle
        //time and hours talk) and features of the screen(size and colors)
        static void Main(string[] args)
        {


            GSM miTelefono = new GSM();
            miTelefono.Manufacturer = "Samsung";
            miTelefono.Model = "S9";
            miTelefono.Price = 150.20d;
            miTelefono.Owner = "Oscar Carranza";

            miTelefono.AgregarLlamada(new Call(DateTime.Today, "9:43 pm", "25 minutos"));
            miTelefono.AgregarLlamada(new Call(DateTime.Today, "9:50 pm", "27 minutos"));
            miTelefono.AgregarLlamada(new Call(DateTime.Today, "9:55 pm", "30 minutos"));

            miTelefono.ImprimirListaDeLlamadas();
            Console.WriteLine("Costo de llamadas: "+miTelefono.FacturarLlamadas());





            Battery mibateria = new Battery(Battery.Bateria.Litio2)
            {
                Tamaño = Battery.Bateria.Litio
            };

            Display miPantalla = new Display();
            miPantalla.Tamaño = Display.SizeDisplay.Medium;




            Console.ReadKey();



        }
    }
}
