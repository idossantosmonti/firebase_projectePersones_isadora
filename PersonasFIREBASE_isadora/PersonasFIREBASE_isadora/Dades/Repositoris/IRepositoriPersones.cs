using Firebase.Database;
using PersonasFIREBASE_isadora.Dades.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonasFIREBASE_isadora.Dades.Repositoris
{
    public interface IRepositoriPersones
    {
        Task<IReadOnlyCollection<FirebaseObject<Persona>>> GetPersonas();
        void AddPersona(Persona persona, string nom);

        void UpdatePersona(string nomPersona, string nomNouPersona, Persona personaObj);
        void DeletePersona(string nom);
    }
}
