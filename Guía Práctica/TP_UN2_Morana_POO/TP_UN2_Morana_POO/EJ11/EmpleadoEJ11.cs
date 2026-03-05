using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UN2_Morana_POO.EJ11
{
    public class EmpleadoEJ11 : PersonaEJ11
    {
        private int legajo;
        public int Legajo
        {
            get { return legajo; }
            set { legajo = value; }
        }

        // USO DE this EN CONSTRUCTORES 
        // Particularidad: this(...) llama a OTRO constructor de la MISMA clase.
        public EmpleadoEJ11(string nombre) : this(nombre, 0)
        {
            // Este cuerpo se ejecuta después de que termine el constructor Empleado(nombre, legajo)
        }

        // USO DE base EN CONSTRUCTORES
        // Particularidad: base(...) inicializa la parte HEREDADA (Persona).
        public EmpleadoEJ11(string nombre, int legajo) : base(nombre)
        {
            this.legajo = legajo; // this = referencia a la instancia actual
            Console.WriteLine($"[DERIV CTOR] Empleado creado: {this.Nombre} - Legajo {this.legajo}");
        }

        // DEMOSTRACIÓN DE base para acceder a miembros base 
        public string DescribirBase()
        {
            // base.Describir() llama explícitamente la versión de la clase base
            return base.Describir();
        }

        // OVERRIDE (para mostrar contraste con base)
        public override string Describir()
        {
            return $"Empleado: {Nombre} - Legajo {Legajo}";
        }

        // FINALIZADOR DERIVADO 
        ~EmpleadoEJ11()
        {
            Console.WriteLine($"[DERIV FINALIZER] Empleado finalizado: {Nombre} - Legajo {legajo}");
        }
    }
}
