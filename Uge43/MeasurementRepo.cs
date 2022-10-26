using System;
using System.Xml.Linq;

namespace Uge43
{
    public class MeasurementRepo
    {
        public double MasterID { get; set; }
        public DateTime FromDateTime { get; set; }
        public DateTime ToDateTime { get; set; }
        public double Value { get; set; }

        public MeasurementRepo(double masterID, DateTime fromDateTime, DateTime toDateTime, double value)
        {
            MasterID = masterID;
            FromDateTime = fromDateTime;
            ToDateTime = toDateTime;
            Value = value;
        }
        public MeasurementRepo() : this(0, DateTime.Now, DateTime.Now, 0) { }

        public override string ToString()
        {
            return MasterID + ";" + FromDateTime + ";" + ToDateTime + ";" + Value;
        }     
    }
}