using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UN2_Morana_POO.EJ12
{
    public abstract class Documento // Clase asbtracta
    {
        private string numero;

        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        protected Documento(string numero)
        {
            this.numero = numero;
        }

        // Método virtual que puede ser sobrescrito por clases derivadas
        public virtual string ObtenerResumen() 
        {
            return $"Documento N° {numero}";
        }

        // Clase anidada (nested class) dentro de Documento
        public class Estado
        {
            private bool aprobado;

            public bool Aprobado
            {
                get { return aprobado; }
                set { aprobado = value; }
            }

            public Estado(bool aprobado)
            {
                this.aprobado = aprobado;
            }
        }
    }
}
