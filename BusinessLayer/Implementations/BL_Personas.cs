using BusinessLayer.Interfaces;
using DataAccessLayer.Interfaces;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Implementations
{
    public class BL_Personas : IBL_Personas
    {
        private IDAL_Personas _personas;
        public BL_Personas(IDAL_Personas personas)
        {
            _personas = personas;
        }

        public Persona AddPersona(Persona x)
        {
            return _personas.AddPersona(x);
        }

        public Persona Get(string documento)
        {
            return _personas.Get(documento);
        }

        public List<Persona> GetPersonas()
        {
            return _personas.GetPersonas();
        }
    }
}
