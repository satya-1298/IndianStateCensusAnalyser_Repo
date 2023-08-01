using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStatesCensusAnalyser_Problem
{
    public class Program
    {
        public static string path = @"C:\Users\PC\Desktop\RFP288\IndianStateCensusAnalyser_Repo\IndianStatesCensusAnalyser_Problem\Files\StateCensusData.csv";

        static void Main(string[] args)
        {


            Console.WriteLine(path);
            StateCensusAnalyser stateCensusAnalyser = new StateCensusAnalyser();
            stateCensusAnalyser.ReadStateCensusData(path);


            CSV_Census cSV_Census = new CSV_Census();
            cSV_Census.ReadStateCensusData(path);


        }
    }
}
