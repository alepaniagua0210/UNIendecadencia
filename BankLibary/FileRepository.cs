using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibary
{
    public class FileRepository : IFileRepository
    {
        private StreamWriter? _fileWriter; // escribe datos en el archivo de texto
        private StreamReader? _fileReader; // lee datos en el archivo de texto 
        private FileStream? _fileStream; // mantiene la conexión con el archivo 
        private string _fileName;

        public FileRepository(string fileName) 
        {
            _fileName = fileName;
        }
        public void CloseFile()
        {
            try
            {
                _fileWriter?.Close(); //cierra StreamWriter
                _fileReader?.Close(); // cierra StreamReader
            }
            catch (IOException)
            {

                throw new IOException("No se puede cerrar el archivo");
            }
        }

        public void OpenFile()
        {
            try
            {
                // crea objeto FileStream para obtener acceso de lectura al archivo
                _fileStream = new FileStream(_fileName, FileMode.Open, FileAccess.Read);

                //establece el archivo del que se van a leer los datos
                _fileReader = new StreamReader(_fileStream);
            }
            catch (IOException)
            {

                throw new IOException("Error al abrir el archivo");
            }
        }

        public void OpenOrCreateFile()
        {
            try
            {
                // abre el archivo con acceso de escritura
                _fileStream = new FileStream(_fileName, FileMode.OpenOrCreate, FileAccess.Write);

                // establece el archivo para escribir los datos
                _fileWriter = new StreamWriter(_fileStream);
            }
            catch (IOException)
            {

                throw new IOException("Error al abrir el archivo");
            }
        }

        public string? ReadNextRecord()
        {
            try
            {
                return _fileReader?.ReadLine();
            }
            catch (IOException)
            {

                throw new IOException("Error al leer del archivo");
            }
        }

        public void ResetFilePointer()
        {
            try
            {
                _fileStream?.Seek(0, SeekOrigin.Begin);
            }
            catch (IOException)
            {

                throw new IOException("Error al reestablecer el puntero del archivo+");
            }
        }

        public void WriteRecordFile(Record record)
        {
            try
            {
                // escribe Record al archivo, los campos separados por comas 
                _fileWriter?.Write($"{record.Account}, {record.FirstName}, {record.LastName}, {record.Balance}");
            }
            catch (IOException)
            {

                throw new IOException("Error al escribir el archivo");
            }
        }
    }
}
