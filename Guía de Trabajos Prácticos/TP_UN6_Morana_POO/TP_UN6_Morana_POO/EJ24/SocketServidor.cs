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
    public class SocketServidor
    {
        // El servidor se mantiene escuchando en un puerto, aceptando clientes y leyendo mensajes en un loop asíncrono.
        private TcpListener listener;
        private CancellationTokenSource cts;

        // Eventos para comunicar cambios de estado y mensajes recibidos al formulario
        public event EventHandler<string> MensajeRecibido;
        public event EventHandler<string> EstadoCambiado;

        public bool Activo { get; private set; }

        public void Iniciar(int puerto) // El puerto en el que el servidor escuchará conexiones entrantes
        {
            if (Activo) return;

            cts = new CancellationTokenSource();
            listener = new TcpListener(IPAddress.Any, puerto);
            listener.Start();
            Activo = true;

            EstadoCambiado?.Invoke(this, $"Servidor escuchando en puerto {puerto}...");
            _ = AceptarYLeerLoopAsync(cts.Token); 
            // Iniciamos el loop de aceptación y lectura de clientes de forma asíncrona, sin esperar su finalización
        }

        public void Detener()
        {
            try
            {
                if (!Activo) return; // Si el servidor no está activo, no hacemos nada

                cts?.Cancel();
                listener?.Stop();
                Activo = false;

                EstadoCambiado?.Invoke(this, "Servidor detenido.");
            }
            catch
            {
                // Alcanza con evitar que explote el program
            }
        }

        // Este método se ejecuta en un loop asíncrono, aceptando clientes y leyendo mensajes hasta que se cancele el token
        private async Task AceptarYLeerLoopAsync(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                TcpClient cliente = null;

                try
                {
                    EstadoCambiado?.Invoke(this, "Esperando cliente...");
                    cliente = await listener.AcceptTcpClientAsync();

                    var remote = cliente.Client.RemoteEndPoint?.ToString() ?? "cliente";
                    EstadoCambiado?.Invoke(this, $"Cliente conectado: {remote}");

                    using (cliente)
                    using (NetworkStream ns = cliente.GetStream())
                    using (StreamReader reader = new StreamReader(ns))
                    {
                        while (!token.IsCancellationRequested)
                        {
                            string linea = await reader.ReadLineAsync();
                            if (linea == null) break; // cliente cerró conexión

                            MensajeRecibido?.Invoke(this, linea);
                        }
                    }

                    EstadoCambiado?.Invoke(this, "Cliente desconectado.");
                }
                catch (ObjectDisposedException)
                {
                    // listener.Stop()
                    break;
                }
                catch (Exception ex)
                {
                    EstadoCambiado?.Invoke(this, "Error servidor: " + ex.Message);
                    try { cliente?.Close(); } catch { }
                }
            }
        }
    }
}
