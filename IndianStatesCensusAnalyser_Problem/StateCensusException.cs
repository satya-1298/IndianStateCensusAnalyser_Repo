using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStatesCensusAnalyser_Problem
{
    public class StateCensusException:Exception
    {
        public enum ExceptionType
        {
            FILE_NOT_FOUND,
            CSV_FILE_NOT_FOUND

        }
        public ExceptionType type;
        public StateCensusException(ExceptionType type,string message):base(message)
        {
            this.type=type; 
        }

    }

}
