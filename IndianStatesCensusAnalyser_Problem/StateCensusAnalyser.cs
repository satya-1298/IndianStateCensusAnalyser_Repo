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
    public class StateCensusAnalyser
    {
        public int ReadStateCensusData(string path)
        {
            try
            {
                if(File.Exists(path))
                {
                    using (var reader = new StreamReader(path))
                    {
                        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                        {
                            var record = csv.GetRecords<StateCensusData>().ToList();
                            foreach (var data in record)
                            {
                                Console.WriteLine(data.State + " " + data.DensityPerSqKm + " " + data.Population + " " + data.AreaInSqKm + " ");
                            }
                        }
                    }

                }
                else
                {
                    throw new StateCensusException(StateCensusException.ExceptionType.FILE_NOT_FOUND, "File Does not exists");
                }
            }
            catch(StateCensusException sr)
            {
                Console.WriteLine(sr.Message);
            }
            return 0;



        }
    }
}
