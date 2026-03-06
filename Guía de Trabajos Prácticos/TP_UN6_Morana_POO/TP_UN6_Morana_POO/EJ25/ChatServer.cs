using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Text;
using System.Threading;

namespace TP_UN6_Morana_POO.EJ25
{
    public class ChatServer
    {
        TcpListener servidor;
        List<TcpClient> clientes = new List<TcpClient>();

        public Action<string> OnMessage;

        public void Iniciar(int puerto)
        {
            servidor = new TcpListener(IPAddress.Any, puerto);
            servidor.Start();

            Thread hilo = new Thread(EscucharClientes);
            hilo.IsBackground = true;
            hilo.Start();

            if (OnMessage != null)
                OnMessage("Servidor iniciado...");
        }

        void EscucharClientes()
        {
            while (true)
            {
                TcpClient cliente = servidor.AcceptTcpClient();
                clientes.Add(cliente);

                Thread hiloCliente = new Thread(() => ManejarCliente(cliente));
                hiloCliente.IsBackground = true;
                hiloCliente.Start();

                if (OnMessage != null)
                    OnMessage("Cliente conectado");
            }
        }

        void ManejarCliente(TcpClient cliente)
        {
            StreamReader reader = new StreamReader(cliente.GetStream(), Encoding.UTF8);

            while (true)
            {
                try
                {
                    string mensaje = reader.ReadLine();

                    if (mensaje != null)
                    {
                        if (OnMessage != null)
                            OnMessage(mensaje);

                        if (mensaje.StartsWith("/pm"))
                        {
                            string[] partes = mensaje.Split(' ');

                            if (partes.Length >= 3)
                            {
                                string usuario = partes[1];
                                string texto = mensaje.Substring(mensaje.IndexOf(usuario) + usuario.Length + 1);

                                EnviarPrivado(usuario, texto);
                            }
                        }
                        else
                        {
                            Broadcast(mensaje);
                        }
                    }
                }
                catch
                {
                    clientes.Remove(cliente);
                    break;
                }
            }
        }

        void EnviarPrivado(string usuario, string mensaje)
        {
            foreach (TcpClient c in clientes)
            {
                try
                {
                    StreamWriter writer = new StreamWriter(c.GetStream(), Encoding.UTF8);
                    writer.AutoFlush = true;

                    writer.WriteLine("[PRIVADO para " + usuario + "] " + mensaje);
                }
                catch { }
            }
        }

        void Broadcast(string mensaje)
        {
            foreach (TcpClient c in clientes)
            {
                try
                {
                    StreamWriter writer = new StreamWriter(c.GetStream(), Encoding.UTF8);
                    writer.AutoFlush = true;
                    writer.WriteLine(mensaje);
                }
                catch { }
            }
        }
    }
}