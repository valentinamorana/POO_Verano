using InterfacesDelegados.Delegados;
using InterfacesDelegados.Interfaces.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinApp.Modelo.Interfaces;

namespace InterfacesDelegados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DELEGADOS
            Delegado delegado = new Delegado();
            //Delegado.Operacion Suma = delegado.Sumar;
            //Delegado.Operacion Resta = delegado.Restar;
            //Delegado.Operacion Multiplicacion = delegado.Multiplicar;
            //Delegado.Operacion Division = delegado.Dividir;

            //int total = Suma(2, 3);
            //Console.WriteLine(total);
            //total = Resta(5, 3);
            //Console.WriteLine(total);

            Delegado.Operacion operacion = delegado.Sumar;

            int suma = operacion(2, 3);
            Console.WriteLine($"Suma: {suma}");

            operacion = delegado.Restar;
            int resta = operacion(5, 3);
            Console.WriteLine($"Resta: {resta}");

            //Orden superior: Pasaje de métodos como parámetros
            delegado.Operar(delegado.Multiplicar, 4, 5);
            delegado.Operar(delegado.Dividir, 10, 2);



            //CLONADO
            Drone droneA = new Drone();
            droneA.Codigo= 123;
            droneA.Potencia = 3000;
            droneA.Fabricante = new Fabricante { Codigo = 4, Descripcion = "DJI" };

            Drone droneB = droneA.Clone() as Drone; //Antes pasabamos por ejemplo droneA
            //En ese caso nos quedamos con la referencia y si modificabamos el estado de droneB
            //se modificaba el estado de droneA, pero al usar Clone() se crea una nueva instancia con el mismo estado, por lo que al modificar droneB no se modifica droneA

            droneB.Codigo = 45;


            Contador contador = new Contador();
            //IEnumerator e IEnumerable
            foreach (var item in contador)
            {
                Console.WriteLine(item);
            }

            //Uso de IComparable
            var personas = new List<Persona>
            {
                new Persona { Nombre = "Juan", Edad = 30 },
                new Persona { Nombre = "Ana", Edad = 25 },
                new Persona { Nombre = "Luis", Edad = 35 }
            };

            Console.WriteLine("Previo a ordenar:");

            foreach (var persona in personas)
            {
                Console.WriteLine($"{persona.Nombre} - {persona.Edad}");
            }

            personas.Sort();

            Console.WriteLine("Después de ordenar:");

            foreach (var persona in personas)
            {
                Console.WriteLine($"{persona.Nombre} - {persona.Edad}");
            }

            //A través de IComparar
            Persona[] personasArray = personas.ToArray(); //Clono la lista de personas a un array

            Array.Sort(personasArray, new Persona.PersonaDesc());

            Console.WriteLine("Después de ordenar con IComparar Desc:");

            foreach (var persona in personasArray)
            {
                Console.WriteLine($"{persona.Nombre} - {persona.Edad}");
            }

            //Uso de interfaces dentro de colecciones
            List<Robot> robots = new List<Robot>
            {
                new Drone { Codigo = 123, Potencia = 3000, Fabricante = new Fabricante { Codigo = 4, Descripcion = "DJI" } },
                new RobotBipedo(),
                new RobotAnfibio()
            };

            foreach (var robot in robots)
            {
                if (robot is IVolador volador)
                {
                    Console.WriteLine("El robot es un volador.");
                    volador.Volar();
                }
                else if (robot is ICaminador caminador)
                {
                    Console.WriteLine("El robot es un caminador.");
                    caminador.Caminar();
                }
                else if (robot is INadador nadador)
                {
                    Console.WriteLine("El robot es un nadador.");
                    nadador.Nadar();
                }
            }

            List<IVolador> voladores = new List<IVolador>();
            voladores.Add(new Drone { Codigo = 123, Potencia = 3000, Fabricante = new Fabricante { Codigo = 4, Descripcion = "DJI" } });
            voladores.Add(new RobotAnfibio());

            foreach (var volador in voladores)
            {
                volador.Volar();
            }
        }
    }
}
