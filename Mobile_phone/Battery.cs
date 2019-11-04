using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_phone
{
    class Battery
    {
        public enum Bateria
        {
            Litio = 100, Litio2 = 150, Litio3 = 300
        }


        private Bateria tamaño;


        public Bateria Tamaño { get { return tamaño; } set { tamaño = value; } }


        double idleTime;
        double hoursTalk;
        public double IdleTIme { get { return idleTime; } set { idleTime = value; } }
        public double HoursTalk { get { return hoursTalk; } set { hoursTalk = value; } }


        public Battery(Bateria tamaño)
        {
            this.tamaño = tamaño;
        }


    }
}
