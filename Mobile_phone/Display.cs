using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_phone
{
    class Display
    {
        public enum SizeDisplay
        {
            Small = 1, Medium = 2, Large = 3
        }

        string colors;
        SizeDisplay tamañoPantalla;

        public string Colors { get { return colors; } set { colors = value; } }
        public SizeDisplay Tamaño { get { return tamañoPantalla; } set { tamañoPantalla = value; } }

    }
}
