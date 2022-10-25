using System;
using System.Xml.Linq;

namespace Uge43
{
    public class Måledata
    {
        public double MasterID { get; set; }
        public DateTime FromDateTime { get; set; }
        public DateTime ToDateTime { get; set; }
        public double Value { get; set; }

        public Måledata(double masterID, DateTime fromDateTime, DateTime toDateTime, double value)
        {
            MasterID = masterID;
            FromDateTime = fromDateTime;
            ToDateTime = toDateTime;
            Value = value;
        }
        public Måledata()
        {

        }

        public override string ToString()
        {
            return MasterID + ";" + FromDateTime + ";" + ToDateTime + ";" + Value;
        }
        

            
        
    }
}

