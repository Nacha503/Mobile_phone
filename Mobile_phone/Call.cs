using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_phone
{
    class Call
    {

        DateTime fecha;

        string timeOfStart, durationOfTheCall;
        public const double priceCall = 0.17d;




        public Call(DateTime fechaDeLlamada, string timeOfStart, string durationOfTheCall)
        {
            fecha = fechaDeLlamada;
            this.timeOfStart = timeOfStart;
            this.durationOfTheCall = durationOfTheCall;
            
        }

        public DateTime Fecha { get { return fecha; } set { fecha = value; } }
        public string TimeOfStart { get { return timeOfStart; } set { timeOfStart = value; } }

        public string DurationOfTheCall { get { return durationOfTheCall; } set { durationOfTheCall = value; } }

    }
}
