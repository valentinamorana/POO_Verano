using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseFramework.Clase3
{
    internal class ClienteEncapsulamiento
    {
        //Encapsulamiento: ocultar los detalles de implementación y exponer solo lo necesario a través de métodos públicos.
        //Tradicional, típico de lenguajes como Java o C++, python, etc.

        #region Atributos
        private string nombre;

        private string apellido;

        //private string cuit;
        #endregion

        //De manera "tradicional", se crean métodos públicos para acceder a los campos privados, llamados getters y setters
        #region Getters y Setters
        //Lectura del campo nombre
        public string GetNombre()
        {
            return this.nombre;
        }
        //Escribir o actualizar el campo nombre
        public void SetNombre(string nombre)
        {
            this.nombre = nombre.ToUpper();
        }
        //Lectura del campo apellido
        public string GetApellido()
        {
            Console.WriteLine("Se llamó al Get de Apellido");
            return this.apellido;
        }
        //Escribir o actualizar el campo nombre
        public void SetApellido(string apellido)
        {
            this.apellido = apellido.ToUpper();
        }

        //Get de CUIT
        public string GetCuit()
        {
            return cuit;
        }

        //Set de cuit
        private void SetCuit(string cuit)
        {
            if (cuit.StartsWith("20") || cuit.StartsWith("23") || cuit.StartsWith("27") || cuit.StartsWith("30"))
            {
                this.cuit = cuit;
            }
            else
            {
                throw new Exception("CUIT no válido");
            }
        }

        #endregion

        //En C#, existe una forma más sencilla de crear getters y setters, utilizando propiedades
        //que son una especie de métodos especiales que permiten acceder a los campos privados de manera más sencilla y legible.
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        //Ejemplo completo para net 48, en versiones más recientes de C#, se pueden usar propiedades autoimplementadas con inicializadores, lo que simplifica aún más el código.
        private string cuit;

        public string Cuit
        {
            get
            {
                return cuit.ToLower();
            }
            set
            {
                if (value.StartsWith("20") || value.StartsWith("23") || value.StartsWith("27") || value.StartsWith("30"))
                {
                    this.cuit = value;
                }
                else
                {
                    throw new Exception("CUIT no válido");
                }
            }
        } //POCO en .net, java POJO

        private int nroCliente;

        public int NroCliente
        {
            get { return nroCliente; }
            set { nroCliente = value; }
        }


        #region Constructores

        #endregion

        #region Métodos

        public void MostrarInfo()
        {
            this.Nombre = "pepe";
        }   


        #endregion


    }
}
