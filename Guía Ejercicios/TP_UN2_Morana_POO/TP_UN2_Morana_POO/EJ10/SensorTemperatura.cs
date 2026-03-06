using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_UN2_Morana_POO.EJ10
{
    public class SensorTemperatura
    {
        // CAMPO 1 - variable privada que almacena información interna del objeto
        private string idSensor;

        // CAMPO 2 - almacena el valor actual de temperatura
        private double temperatura;

        // EVENTO ESTÁTICO 1 - pertenece a la CLASE y no a una instancia.
        // Puede ser escuchado por todos los objetos del sistema.
        public static event EventHandler TemperaturaAlta;

        // EVENTO ESTÁTICO 2 - al ser estático es compartido por todos los sensores
        public static event EventHandler SensorReiniciado;

        // CONSTRUCTOR - inicializa los campos cuando se crea el objeto
        public SensorTemperatura(string id, double tempInicial)
        {
            idSensor = id;
            temperatura = tempInicial;
        }

        // MÉTODO 1 - modifica el estado interno del objeto
        public void ActualizarTemperatura(double nuevaTemp)
        {
            temperatura = nuevaTemp;

            if (temperatura > 50)  // si supera cierto valor se dispara el evento
            {
                OnTemperaturaAlta();
            }
        }

        // MÉTODO 2 - permite consultar el estado del objeto
        public double ObtenerTemperatura()
        {
            return temperatura;
        }

        // MÉTODO 3 - reinicia el valor del sensor
        public void ReiniciarSensor()
        {
            temperatura = 0;
            OnSensorReiniciado();
        }

        // MÉTODO INVOCADOR DEL EVENTO - dispara el evento estático si existen suscriptores
        protected static void OnTemperaturaAlta()
        {
            TemperaturaAlta?.Invoke(null, EventArgs.Empty);
        }

        // MÉTODO INVOCADOR DEL EVENTO
        protected static void OnSensorReiniciado()
        {
            SensorReiniciado?.Invoke(null, EventArgs.Empty);
        }
    }
}
