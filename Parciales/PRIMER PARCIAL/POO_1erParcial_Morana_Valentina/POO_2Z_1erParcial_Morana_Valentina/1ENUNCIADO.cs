using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_2Z_1erParcial_Morana_Valentina
{
    internal class _1ENUNCIADO
    {
        /* Sistema de Gestión de Alquiler de Vehículos

        Requerimientos:

        Una rent-a-car necesita una aplicación mínima para registrar los vehículos alquilados en el día y calcular el total recaudado.



        1. Modelo de Objetos (50 puntos)

        Se debe implementar la siguiente estructura de clases:

        Vehiculo (Clase Padre):

        Atributos: Patente (string) y PrecioBase (double). Ambos deben ser privados.
        Constructor: Debe inicializar la patente y el precio base.
        Propiedades: Solo lectura (get) para ambos atributos.
        Método Abstracto: double CalcularCosto(int dias), que recibirá la cantidad de días de alquiler.


        Auto (Clase Hija):

        Cálculo de Costo: PrecioBase * dias.


        Furgon (Clase Hija):

        Atributo Adicional: CapacidadCarga (int).
        Cálculo de Costo: (PrecioBase * dias) + 1000. (Tiene un recargo fijo de $1000 por ser vehículo de carga).


        2. Interfaz de Usuario - WinForms (50 puntos)


        El formulario debe contener:

        Campos de texto (TextBox) para ingresar: Patente, Precio Base y Capacidad de Carga.
        Un selector (ComboBox o RadioButtons) para elegir si es Auto o Furgon.
        Un botón "Agregar": Que instancie el objeto según el tipo seleccionado y lo guarde en una lista global de tipo List<Vehiculo>.
        Un botón "Ver Resumen": Que recorra la lista y muestre mediante un MessageBox:
        La suma total de lo recaudado (asumiendo que todos se alquilan por 1 día).
        La cantidad total de vehículos registrados. */
    }
}
