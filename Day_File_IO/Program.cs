using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Day_File_IO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileIOText fileIOText = new FileIOText();
            fileIOText.File_IOText();

            FileIOCSV fileIOCSV = new FileIOCSV();
            fileIOCSV.File_IO__CSV();

            FileIO_JSON fileIO_JSON = new FileIO_JSON();    
            fileIO_JSON.File_IOJSON();
        }
    }
}
    
