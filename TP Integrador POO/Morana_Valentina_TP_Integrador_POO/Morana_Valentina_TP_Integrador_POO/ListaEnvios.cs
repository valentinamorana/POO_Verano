using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morana_Valentina_TP_Integrador_POO
{
    /// <summary>
    /// Repositorio de objetos Envio. Actúa como capa intermedia entre la lógica del formulario y la colección interna.
    /// Implementa IEnumerable de Envio, lo que permite recorrer la
    /// colección directamente con foreach desde cualquier parte del sistema.
    /// </summary>
    
    public class ListaEnvios : IEnumerable<Envio> // Implementa IEnumerable para permitir iterar sobre la colección de envíos
    {
        private List<Envio> envios; // Colección interna de envíos

        public List<Envio> Envios
        {
            get { return envios; }
            set { envios = value; }
        }

        public ListaEnvios()
        {
            envios = new List<Envio>();
        }

        public void Agregar(Envio envio) // Método para agregar un nuevo envío a la colección
        {
            envios.Add(envio);
        }

        public void Eliminar(Envio envio) // Método para eliminar un envío de la colección
        {
            envios.Remove(envio);
        }

        // Implementación del método GetEnumerator para IEnumerable<Envio>
        public IEnumerator<Envio> GetEnumerator() 
        {
            return envios.GetEnumerator();
        }

        // Implementación explícita de IEnumerable.GetEnumerator para cumplir con la interfaz no genérica
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
