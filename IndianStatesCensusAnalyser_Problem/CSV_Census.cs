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
    public class CSV_Census
    {

        public int ReadStateCensusData(string path)
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
                    return record.Count() - 1;
                }

            }


        }
    }
}
