using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStatesCensusAnalyser_Problem
{
    public class Program
    {
        public static string path = @"C:\Users\PC\Desktop\RFP288\IndianStateCensusAnalyser_Repo\IndianStatesCensusAnalyser_Problem\Files\StateCensusDat";
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a Choose");
                Console.WriteLine("1-File Exists");
                Console.WriteLine("2-File extension check");
                int option=Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        Console.WriteLine(path);
                        StateCensusAnalyser stateCensusAnalyser = new StateCensusAnalyser();
                        stateCensusAnalyser.ReadStateCensusData(path);
                        break;
                    case 2:
                        CSV_Census cSV_Census = new CSV_Census();
                        cSV_Census.ReadStateCensusData(path);
                        Console.ReadLine();
                        break;

                }
            }           
        }
    }
}
