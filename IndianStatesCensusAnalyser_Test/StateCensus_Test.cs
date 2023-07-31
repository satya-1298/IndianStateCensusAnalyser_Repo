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
        StateCensusAnalyser stateCensusAnalyser = new StateCensusAnalyser();
        public static string stateCensusCSVFile_Path = @"C:\Users\PC\Desktop\RFP288\IndianStateCensusAnalyser_Repo\IndianStatesCensusAnalyser_Problem\Files\StateCensusData.csv";
        public static string inCorrect_Path = @"C:\Users\PC\Desktop\RFP288\IndianStateCensusAnalyser_Repo\IndianStatesCensusAnalyser_Problem\Files";

        [Test]
        public void GivenStateCensusData_WhenAnalyzed_ShouldReturnNoOfRecordsMatches()
        {
            CSV_Census cSV_Census = new CSV_Census();
            Assert.AreEqual(cSV_Census.ReadStateCensusData(stateCensusCSVFile_Path), stateCensusAnalyser.ReadStateCensusData(stateCensusCSVFile_Path));
        }
        [Test]
        public void GivenStateCensus_CSV_File_IncorrectReturns_CustomException()
        {
            try
            {
                int records = stateCensusAnalyser.ReadStateCensusData(inCorrect_Path);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "File is not found");
            }
        }
    }
}
