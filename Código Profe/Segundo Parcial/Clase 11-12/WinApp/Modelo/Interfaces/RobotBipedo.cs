using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinApp.Modelo.Interfaces
{
    internal class RobotBipedo : Robot, ICaminador
    {
        public void Caminar()
        {
            Console.WriteLine("Soy un robot bípedo y estoy caminando...");
        }
    }
}
