using Firebase.Database;
using PersonasFIREBASE_isadora.Dades.Model;
using PersonasFIREBASE_isadora.Dades.Repositoris;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonasFIREBASE_isadora.Domini
{
    public class DominiPersonas : IDominiPersonas
    {
        public IRepositoriPersones RepositoriPersona { get; set; }

        public DominiPersonas()
        {
            RepositoriPersona = new RepositoriPersones();
        }

        public Task<IReadOnlyCollection<FirebaseObject<Persona>>> ObtenirPersonas()
        {
            return RepositoriPersona.GetPersonas();
        }
        public void AfegirPersona(Persona p, string n)
        {
            RepositoriPersona.AddPersona(p, n);
        }

        public void UpdatePersona(string nomPersona, string nomNouPersona, Persona personaObj)
        {
            RepositoriPersona.UpdatePersona(nomPersona, nomNouPersona, personaObj);
        }
        public void DeletePersona(string nomPersona)
        {
            RepositoriPersona.DeletePersona(nomPersona);
        }
    }
}
