using AccesoDatos;
using ClaseFramework.Clase2;
using ClaseFramework.Clase3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClaseFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Clase 3
            ClienteEncapsulamiento cliente = new ClienteEncapsulamiento();
            cliente.Nombre = "Juan";
            cliente.SetApellido("Perez");
            Console.WriteLine($"El cliente tiene como nombre {cliente.Nombre}");
            Console.WriteLine($"El cliente tiene como apellido {cliente.GetApellido()}");

            cliente.Cuit = "20-12345678-9";

            //Esto saldría por error crítico -> Se detiene el programa porque nos falta ver mecanismos de excepciones
            //cliente.Cuit = "99-12345678-9";

            Console.WriteLine($"El cliente tiene de CUIT: {cliente.Cuit}");


            Clase2();

            //Clase 1
            Instanciacion();
        }

        private static void Clase2()
        {
            Console.WriteLine("Bienvenidos");

            Cajero cajero = new Cajero();
            Console.WriteLine(cajero);
            cajero.MostrarInfo();
            cajero.MostrarMontoMaximo();
            cajero.MostrarInfoPersona();

            Cliente cliente = new Cliente();
            Console.WriteLine(cliente);
            cliente.MostrarInfo();
            cliente.MostrarNumeroCliente();
            cliente.MostrarInfoPersona();

            Oficial oficial = new Oficial();
            Console.WriteLine(oficial);
            oficial.MostrarInfo();
            oficial.MostrarCantidadClientesActivos();
            oficial.MostrarInfoPersona();

            List<object> lista = new List<object>();
            lista.Add(cajero);
            lista.Add(cliente);
            lista.Add(oficial);

            //Claro ejemplo de polimorfismo utilizando la herencia de la clase base Object
            foreach (object obj in lista)
            {
                Console.WriteLine(obj);
            }

            MostrarPersona(oficial);

            List<Persona> listaPersonas = new List<Persona>();
            listaPersonas.Add(cajero);
            listaPersonas.Add(cliente);
            listaPersonas.Add(oficial);

            foreach (Persona persona in listaPersonas)
            {
                MostrarPersona(persona);
            }
        }

        private static void MostrarPersona(Persona p)
        {
            //Si quiero acceder a miembros propios de los subtipos, debo hacer un casteo
            //if(p is Cliente)
            //{
            //    Cliente cliente = (Cliente)p;
            //    cliente.MostrarNumeroCliente
            //}

            p.MostrarInfo();
            p.MostrarInfoPersona();
            //En este punto, hay polimorfismo, se llama al método correspondiente al tipo real del objeto, no al tipo declarado en la firma del método
            Console.WriteLine(p);
        }

        private static void Instanciacion()
        {
            // Creamos una instancia de FileManager
            // Declaración de variable = instanciación de la clase
            FileManager fileManager1 = new FileManager();
            fileManager1.maxFileSize = "10MB";

            FileManager fileManager2 = new FileManager();
            fileManager2.maxFileSize = "20MB";

            //Ver estado de los objetos
            fileManager1.MostrarInfo();
            fileManager2.MostrarInfo();

            FileManager fileManager3 = fileManager1;

            //FileManager file2;
            //file2 = new FileManager();

            //Comparamos las dos instancias, estamos comparando las referencias en memoria
            Console.WriteLine(fileManager1 == fileManager2);

            //En este caso ambas variables apuntan a la misma referencia en memoria
            Console.WriteLine(fileManager1 == fileManager3);

            //Cuando imprimimos un objeto, se llama al método ToString()
            //Por defecto se muestra el nombre del espacio de nombres + nombre de la clase = fullname
            Console.WriteLine(fileManager1);

            //Configuration conf = new AccesoDatos.Configuration();
        }
    }
}
