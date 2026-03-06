using System;
using System.Net.Sockets;
using System.IO;
using System.Text;
using System.Threading;

namespace TP_UN6_Morana_POO.EJ25
{
    public class ChatClient
    {
        TcpClient cliente;
        StreamWriter writer;

        public Action<string> OnMessage;

        public void Conectar(string ip, int puerto)
        {
            cliente = new TcpClient(ip, puerto);

            writer = new StreamWriter(cliente.GetStream(), Encoding.UTF8);
            writer.AutoFlush = true;

            Thread hilo = new Thread(RecibirMensajes);
            hilo.IsBackground = true;
            hilo.Start();
        }

        void RecibirMensajes()
        {
            StreamReader reader = new StreamReader(cliente.GetStream(), Encoding.UTF8);

            while (true)
            {
                try
                {
                    string mensaje = reader.ReadLine();

                    if (OnMessage != null && mensaje != null)
                        OnMessage(mensaje);
                }
                catch
                {
                    break;
                }
            }
        }

        public void Enviar(string mensaje)
        {
            writer.WriteLine(mensaje);
        }
    }
}