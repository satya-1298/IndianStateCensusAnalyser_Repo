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
        CSV_State cSV_State = new CSV_State();
        public static string stateCensusCSVFile_Path = @"C:\Users\PC\Desktop\RFP288\IndianStateCensusAnalyser_Repo\IndianStatesCensusAnalyser_Problem\Files\StateCensusData.csv";
        public static string inCorrect_Path = @"C:\Users\PC\Desktop\RFP288\IndianStateCensusAnalyser_Repo\IndianStatesCensusAnalyser_Problem\Files";
        public static string inCorrect_Type_Path = @"C:\Users\PC\Desktop\RFP288\IndianStateCensusAnalyser_Repo\IndianStatesCensusAnalyser_Problem\Files\StateCensusData.txt";
        public static string delimeter_Path = @"C:\Users\PC\Desktop\RFP288\IndianStateCensusAnalyser_Repo\IndianStatesCensusAnalyser_Problem\Files\StateCensusDataDelimeter.csv";
        public static string CSV_Code_Path = @"C:\Users\PC\Desktop\RFP288\IndianStateCensusAnalyser_Repo\IndianStatesCensusAnalyser_Problem\Files\StateCodeData.csv";

        [Test]
        public void GivenStateCensusData_WhenAnalyzed_ShouldReturnNoOfRecordsMatches()
        {
            CSV_Census cSV_Census = new CSV_Census();
            Assert.AreEqual(cSV_Census.ReadStateCensusData(stateCensusCSVFile_Path), stateCensusAnalyser.ReadStateCensusData(stateCensusCSVFile_Path));
        }
        //tc-2
        [Test]
        public void GivenStateCensus_CSV_File_IncorrectReturns_CustomException()
        {
            try
            {
                int records = stateCensusAnalyser.ReadStateCensusData(inCorrect_Path);
            }
            catch (StateCensusException ex)
            {
                Assert.AreEqual(ex.Message, "File path not found");
            }
        }
        //tc-3
        [Test]
        public void GivenStateCensus_CSV_File_CorrectBut_Type_IncorrectReturns_CustomException()
        {
           
            try
            {
                CSV_Census cSV_Census= new CSV_Census();
                int records = cSV_Census.ReadStateCensusData(inCorrect_Type_Path);
            }
            catch (StateCensusException ex)
            {
                Assert.AreEqual(ex.Message, "File is not CSV type");
            }
        }
        //tc-4
        [Test]
        public void GivenStateCensus_CSV_File_When_CorrectButDelimiter_Incorrect_Returns_CustomException()
        {
            try
            {
                int records = stateCensusAnalyser.ReadStateCensusData(delimeter_Path);
            }
            catch (StateCensusException ex)
            {
                Assert.AreEqual(ex.Message, "Incorrect delimeter");
            }
        }
        //UC2-TC1
        [Test]
        public void GivenCSV_stateData_WhenAnalyzed_ShouldReturnNoOfRecordsMatches()
        {
            StateCodeAnalyser stateCodeAnalyser = new StateCodeAnalyser();
            Assert.AreEqual(cSV_State.DisplayData(CSV_Code_Path), stateCodeAnalyser.DisplayData(CSV_Code_Path));

        }
        //tc-2
        [Test]
        public void GivenCSV_State_DataWhenGivenInCorrectFile_Return_CustomException()
        {
            try
            {
                int records = cSV_State.DisplayData(inCorrect_Path);
            }
            catch (StateCensusException ex)
            {
                Assert.AreEqual(ex.Message, "File path not found");
            }
        }
        [Test]
        public void GivenCSV_StateData_WhenGivenIncorrect_Extension_Return_CustomException()
        {
            try
            {
                int records = cSV_State.DisplayData(inCorrect_Type_Path);
            }
            catch (StateCensusException ex)
            {
                Assert.AreEqual(ex.Message, "File is not CSV type");
            }
        }
    }
}
