using IndianStatesCensusAnalyser_Problem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStatesCensusAnalyser_Test
{
    public class StateCensus_Test
    {
        public static string stateCensusCSVFile_Path = @"C:\Users\PC\Desktop\RFP288\IndianStateCensusAnalyser_Repo\IndianStatesCensusAnalyser_Problem\Files\StateCensusData.csv";
        [Test]
        public void MatchFiles()
        {
            StateCensusAnalyser stateCensusAnalyser = new StateCensusAnalyser();
            CSV_Census cSV_Census = new CSV_Census();
            Assert.AreEqual(cSV_Census.ReadStateCensusData(stateCensusCSVFile_Path), stateCensusAnalyser.ReadStateCensusData(stateCensusCSVFile_Path));
        }
    }
}
