using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibary
{
    public interface IFileRepository
    {
        void OpenOrCreateFile();
        void OpenFile();
        void WriteRecordFile(Record record);
        string? ReadNextRecord();
        void ResetFilePointer();
        void CloseFile(); 
    }
}
