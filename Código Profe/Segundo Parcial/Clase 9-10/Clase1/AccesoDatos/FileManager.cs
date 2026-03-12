using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    /// <summary>
    /// Provides methods for managing file operations such as reading, writing, and deleting files.
    /// </summary>
    public class FileManager
    {
        /// <summary>
        /// Atributo que almacena la ruta del archivo.
        /// </summary>
        private string filePath; //@"d:\Logs"; //Evitar hardcoding

        /// <summary>
        /// Atributo que almacena el nombre del archivo.
        /// </summary>
        private string fileName;

        public string maxFileSize;

        /// <summary>
        /// Displays information about the current file manager instance to the console.
        /// </summary>
        /// <remarks>This method writes details such as the file path, file name, and maximum file size to
        /// the standard output. It is intended for diagnostic or informational purposes and does not modify the state
        /// of the object.</remarks>
        public void MostrarInfo()
        {
            Console.WriteLine("FileManager Info:");
            Console.WriteLine($"File Path: {filePath}");
            Console.WriteLine($"File Name: {fileName}");
            Console.WriteLine($"Max File Size: {maxFileSize}");
        }


        //toString
        override public string ToString()
        {
            return $"FileManager: Path={filePath}, Name={fileName}, MaxSize={maxFileSize}";
        }
    }
}
