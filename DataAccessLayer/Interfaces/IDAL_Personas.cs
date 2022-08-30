using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IDAL_Personas
    {
        List<Persona> GetPersonas();

        Persona Get(string documento);

        Persona AddPersona(Persona x);
    }
}
