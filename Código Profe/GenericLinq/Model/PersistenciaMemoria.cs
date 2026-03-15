using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLinq.Model
{
    internal interface IPersistenciaMemoria<T> where T : class
    {
        /// <summary>
        /// Método que deberá guardar el objeto en cuestión
        /// </summary>
        /// <param name="valor"></param>
        void Guardar(T valor);
        T Obtener(int id);
        void Eliminar(int id);
        void Actualizar(T valor);
        List<T> TraerTodos();

    }
}
