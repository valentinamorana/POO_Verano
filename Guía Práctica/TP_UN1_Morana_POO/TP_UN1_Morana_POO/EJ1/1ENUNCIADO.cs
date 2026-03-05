using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UN1_Morana_POO.EJ1
{
    internal class ENUNCIADO
    {
        /* Desarrollar una jerarquía de clases relacionadas por herencia y agregación que represente la estructura necesaria para identificar claramente los elementos encontrados en un 
        sistema de calificaciones de una universidad. En cada clase detallar métodos y propiedades. */

        /* EL MAPA DEL SISTEMA: 
          
        - Universidad = el “contenedor” del sistema (tiene alumnos, profesores, facultades).

        - Facultad → Carrera → Materia → Comisión = la estructura académica.

        - Alumno se relaciona con una Comisión a través de un Estado.

        - Estado guarda la Calificación (una sola) y el tipo de estado (regular/aprobado/etc.).

        - Profesor es el responsable de una comisión y el que asigna la calificación. */
    }
}
