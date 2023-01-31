using Firebase.Database;
using Firebase.Database.Query;
using PersonasFIREBASE_isadora.Dades.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonasFIREBASE_isadora.Dades.Repositoris
{
    public class RepositoriPersones : IRepositoriPersones
    {
        public FirebaseClient Firebase { get; set; }

        public RepositoriPersones()
        {
            Firebase = FireBaseClient.GetFireBaseClient();
        }

        public async Task<IReadOnlyCollection<FirebaseObject<Persona>>> GetPersonas()
        {
            return await Firebase.Child("PersonasObject")
                .OrderByKey()
                .OnceAsync<Persona>();
        }

        public async void AddPersona(Persona persona, string nom)
        {


            await Firebase.Child("PersonasObject").Child(nom)
                .PutAsync<Persona>(persona); // afegir

            //await Firebase.Child("PersonasObject/-NMZnHfbJAQADnWdSNIP")
            //    .PatchAsync<Persona>(nea); //actualitzar

            //await Firebase.Child("PersonasObject/-NMZnHfbJAQADnWdSNIP"); //actualitzar
        }

        public async void UpdatePersona(string nomPersona, 
            string nomNouPersona, Persona personaObj)
        {
            //Firebase.Child("PersonasObject/" + nomPersona);
            if (nomPersona == nomNouPersona)
                await Firebase.Child("PersonasObject/" + nomPersona)
                    .PatchAsync<Persona>(personaObj); //actualitzar
            else
            {
                await Firebase.Child("PersonasObject/" + nomPersona).DeleteAsync();
                await Firebase.Child("PersonasObject").Child(nomNouPersona)
                .PutAsync<Persona>(personaObj);
            }
                
        }

        public async void DeletePersona(string nom)
        {
            await Firebase.Child("PersonasObject/" + nom).DeleteAsync();
        }
    }
}
