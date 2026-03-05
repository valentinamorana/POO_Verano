using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_UN2_Morana_POO.EJ9
{
    public class GestorPedido
    {
        private Pedido pedido;

        public GestorPedido() // Constructor donde se instancia el pedido y se suscriben los eventos
        {
            pedido = new Pedido("PED001", 5);

            // Suscripción manual a funciones de esta misma clase
            pedido.PedidoConfirmado += PedidoConfirmadoHandler;
            pedido.CantidadModificada += CantidadModificadaHandler;
        }

        public void Probar() // Método para probar la funcionalidad del pedido y disparar los eventos
        {
            pedido.ModificarCantidad(10);
            pedido.ConfirmarPedido();
        }

        // Handlers para los eventos, que serán llamados cuando se disparen los eventos correspondientes
        private void PedidoConfirmadoHandler(object sender, EventArgs e)
        {
            MessageBox.Show("Evento: pedido confirmado.");
        }

        private void CantidadModificadaHandler(object sender, EventArgs e)
        {
            MessageBox.Show("Evento: cantidad modificada.");
        }
    }
}
