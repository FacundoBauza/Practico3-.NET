using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IBL_Personas
    {
        List<Persona> GetPersonas();

        Persona Get(string documento);

        Persona AddPersona(Persona x);
    }
}
