using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace TP_UN6_Morana_POO.EJ24
{
    public class SocketCliente
    {
        // En este caso, el cliente solo se conecta, envía mensajes y se desconecta. No necesita un loop de lectura.
        private TcpClient client;
        private StreamWriter writer;

        public bool Conectado => client != null && client.Connected;

        // Método para conectar al servidor
        public void Conectar(string ip, int puerto)
        {
            if (Conectado) return;

            client = new TcpClient();
            client.Connect(ip, puerto); 

            NetworkStream ns = client.GetStream(); // El cliente solo escribe, no lee, así que no necesitamos un StreamReader
            writer = new StreamWriter(ns, Encoding.UTF8) { AutoFlush = true }; // AutoFlush para que se envíe inmediatamente sin necesidad de llamar a Flush()
        }

        // Método para enviar un mensaje al servidor
        public void Enviar(string mensaje)
        {
            if (!Conectado) throw new InvalidOperationException("Cliente no conectado.");

            // Usamos WriteLine para que el servidor lea por líneas (ReadLine)
            writer.WriteLine(mensaje);
        }

        public void Desconectar()
        {
            try // Alcanza con evitar que explote, aunque lo ideal sería manejar excepciones específicas
            {
                writer?.Dispose();
                client?.Close();
            }
            catch { }
            finally
            {
                writer = null;
                client = null;
            }
        }
    }
}
