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

         double timeOfStart, durationOfTheCall;




        public Call(DateTime fechaDeLlamada, double timeOfStart, double durationOfTheCall)
        {
            fecha = fechaDeLlamada;
            this.timeOfStart = timeOfStart;
            this.durationOfTheCall = durationOfTheCall;
        }

        public DateTime Fecha { get { return fecha; } set { fecha = value; } }
        public double TimeOfStart { get { return timeOfStart; } set { timeOfStart = value} }

        public double DurationOfTheCall { get { return durationOfTheCall; } set { durationOfTheCall = value; } }

    }
}
