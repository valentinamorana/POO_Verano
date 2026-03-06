using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UN4_Morana_POO.EJ20
{
    public class Alumno
    {
        public string Nombre { get; set; }
        public int Nota { get; set; }

        public Alumno(string nombre, int nota) 
        {
            Nombre = nombre;
            Nota = nota;
        }

        public override string ToString() // Para mostrar la información del alumno
        {
            return $"{Nombre} - Nota: {Nota}";
        }
    }
}
