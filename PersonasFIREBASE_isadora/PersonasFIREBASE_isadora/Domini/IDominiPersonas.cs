using Firebase.Database;
using PersonasFIREBASE_isadora.Dades.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonasFIREBASE_isadora.Domini
{
    public interface IDominiPersonas
    {
        Task<IReadOnlyCollection<FirebaseObject<Persona>>> ObtenirPersonas();
        void AfegirPersona(Persona p, string s);
        void UpdatePersona(string nomPersona, string nomNouPersona, Persona personaObj);
        void DeletePersona(string nomPersona);
    }
}
