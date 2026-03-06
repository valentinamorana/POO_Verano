using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_UN1_Morana_POO.EJ5.Clasificacion;

namespace TP_UN1_Morana_POO.EJ5.Dominio
{
    public abstract class MedioTransporte
    {
        // NOTA: Para este ejercicio se modelan solo algunos atributos mínimos (nombre y si es motorizado)
        // para enfocarnos en la idea de clasificación (clásica, conceptual y prototípica).
        // En un sistema real podrían agregarse muchos más (capacidad, velocidad, consumo, etc.).

        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private bool esMotorizado;
        public bool EsMotorizado
        {
            get { return esMotorizado; }
            set { esMotorizado = value; }
        }

        protected MedioTransporte(string nombre, bool esMotorizado)
        {
            this.nombre = nombre;
            this.esMotorizado = esMotorizado;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
