using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinApp.Modelo
{
    internal class Proveedor : Persona, IDisposable
    {
        public EventHandler CambioRazonSocial;

        public EventHandler<ProveedorEventArgs> CambrioRazonSocialArgs;

        private string _razonSocial;
        public string RazonSocial {
            get
            {
                return _razonSocial;
            } 
            set {
                _razonSocial = value;

                ////Deberíamos disparar el evento CambioNombre cada vez que se cambie el nombre del proveedor, para que los formularios que lo estén utilizando puedan actualizar su información de manera automática.
                //CambioNombre(this, null); //No recomendado porque no valida si hay suscriptores al evento, lo correcto sería validar antes de disparar el evento.

                ////Manera segura de disparar el evento, validando que haya suscriptores
                //if (CambioNombre != null) //Validamos que haya suscriptores al evento antes de dispararlo
                //{
                //    CambioNombre(this, null);
                //}

                //Manera más moderna de disparar el evento, utilizando el operador de propagación nula (?.) para validar que haya suscriptores antes de disparar el evento.
                CambioRazonSocial?.Invoke(this, null);
                CambrioRazonSocialArgs?.Invoke(this, new ProveedorEventArgs(_razonSocial));
            }
        }

        public Proveedor(string dni, string razonsocial) : base(dni)
        {
            this.RazonSocial = razonsocial;
        }

        public Proveedor(string dni, DateTime fechaAlta, string razonsocial) : base(dni, fechaAlta)
        {
            this.RazonSocial = razonsocial;
        }

        #region destructor y dispose

        ~Proveedor() {
            //Limpieza de recursos no administrados, como conexiones a bases de datos, archivos, etc.
            Console.WriteLine("Limpiando recursos no administrador por .NET");
            Console.WriteLine("Eliminando el proveedor de la memoria");
        }

        public void Dispose()
        {
            //Esta técnica se utiliza para liberar recursos de manera programática de recursos administrados
            //como memoria, colecciones, etc. Es una buena práctica implementar esta técnica para liberar recursos de manera rápida y eficiente.
            Console.WriteLine("Liberando recursos de manera programática (Rápida)");

            //Evita que el recolector de basura llame al destructor, ya que los recursos ya han sido liberados.
            GC.SuppressFinalize(this); 
        }
        #endregion
    }

    internal class ProveedorEventArgs : EventArgs
    {
        public string RazonSocial { get; set; }
        public ProveedorEventArgs(string razonSocial)
        {
            this.RazonSocial = razonSocial;
        }
    }
}
