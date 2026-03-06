using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UN6_Morana_POO.EJ26
{
    [Flags]
    public enum LineasStatus
    {
        Ninguna = 0,
        Busy = 1,        // equipo ocupado
        Ack = 2,         // confirmación
        PaperOut = 4,    // sin papel
        Selected = 8,    // dispositivo seleccionado
        Error = 16       // error
    }

    public class PuertoParaleloEmulado
    {
        // "Registros" emulados
        private byte data;                 // DATA register (salida)
        private LineasStatus status;        // STATUS register (entrada)

        public byte Data
        {
            get { return data; }
            private set { data = value; }
        }

        public LineasStatus Status
        {
            get { return status; }
            private set { status = value; }
        }

        // Eventos (sucesos) para notificar cambios
        public event EventHandler<byte> DatosEnviados;
        public event EventHandler<LineasStatus> EntradasActualizadas;

        // Enviar señales al puerto (8 bits)
        public void EnviarDatos(byte valor)
        {
            Data = valor;
            DatosEnviados?.Invoke(this, Data);

            // Emulación simple de respuesta del “dispositivo”:
            // si el valor es par => Ack, si es impar => Busy
            if (valor % 2 == 0)
                ActualizarEntradas(LineasStatus.Ack | LineasStatus.Selected);
            else
                ActualizarEntradas(LineasStatus.Busy | LineasStatus.Selected);
        }

        // Recolectar entradas (leer status)
        public LineasStatus LeerEntradas()
        {
            return Status;
        }

        // Permite al emulador cambiar entradas (simulando el hardware)
        public void ActualizarEntradas(LineasStatus nuevas)
        {
            Status = nuevas;
            EntradasActualizadas?.Invoke(this, Status);
        }

        // “Reset” del puerto
        public void Reset()
        {
            Data = 0;
            ActualizarEntradas(LineasStatus.Ninguna);
        }
    }
}
