using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UN2_Morana_POO.EJ9
{
    public class Pedido
    {
        private string codigo;
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        private int cantidad;
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public event EventHandler PedidoConfirmado;
        public event EventHandler CantidadModificada;

        public Pedido(string codigo, int cantidad)
        {
            this.codigo = codigo;
            this.cantidad = cantidad;
        }

        // Método para confirmar el pedido, que disparará el evento PedidoConfirmado
        public void ConfirmarPedido()
        {
            OnPedidoConfirmado();
        }

        // Método para modificar la cantidad, que disparará el evento CantidadModificada
        public void ModificarCantidad(int nuevaCantidad)
        {
            cantidad = nuevaCantidad;
            OnCantidadModificada();
        }

        //  Métodos protegidos para invocar los eventos de forma segura
        protected virtual void OnPedidoConfirmado()
        {
            PedidoConfirmado?.Invoke(this, EventArgs.Empty);
        }

        protected virtual void OnCantidadModificada()
        {
            CantidadModificada?.Invoke(this, EventArgs.Empty);
        }
    }
}
