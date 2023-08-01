using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStatesCensusAnalyser_Problem
{
    public class CSV_State
    {

        public int DisplayData(string path)
        {
            if (!File.Exists(path))
                throw new StateCensusException(StateCensusException.ExceptionType.FILE_NOT_FOUND, "File path not found");
            if(!path.EndsWith(".csv"))
                throw new StateCensusException(StateCensusException.ExceptionType.CSV_FILE_NOT_FOUND, "File is not CSV type");
            using (var read=new StreamReader(path))
            {
                using(var records=new CsvReader(read, CultureInfo.InvariantCulture))
                {
                    var data = records.GetRecords<CSV_Code_Model>().ToList();
                    foreach (var record in data)
                    {
                        Console.WriteLine(record.SrNo+"  "+record.StateName+"  "+record.TIN+"  "+record.StateCode+"  ");
                    }
                    return data.Count()-1;
                }
            }
            
        }
    }
}
