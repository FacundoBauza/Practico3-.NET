using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Persona
    {
        public long Id { get; set; }
        public string Nombre { get; set; } = "-- Sin Nombre --";
        private string documento;
        public string Documento { get 
            { 
                return documento;
            }
            set 
            {
                if (value.Length < 7)
                    throw new ArgumentException("El documento debe tener largo 7 o mayor");
                documento = value.ToUpper();
            }
        }
    }
}
