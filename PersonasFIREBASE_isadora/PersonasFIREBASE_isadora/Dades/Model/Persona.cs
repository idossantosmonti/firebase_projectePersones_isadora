using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonasFIREBASE_isadora.Dades.Model
{
    public class Persona
    {
        public bool disponibilidadParaViajar { get; set; }
        public int edad { get; set; }
        public IList<string> lenguajes { get; set; }
        public string profesion { get; set; }
        public RangoProfesional rangoProfesional { get; set; }
    }

    public enum Disponibilidad { Dolenta = 0, Bona = 1};
}
