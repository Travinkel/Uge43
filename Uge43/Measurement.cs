using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uge43
{
    public class Measurement
    {
        public double MasterID { get; set; }
        public DateTime FromDateTime { get; set; }
        public DateTime ToDateTime { get; set; }
        public double Value { get; set; }

        public Measurement(double masterID, DateTime fromDateTime, DateTime toDateTime, double value)
        {
            MasterID = masterID;
            FromDateTime = fromDateTime;
            ToDateTime = toDateTime;
            Value = value;
        }

        public override string ToString()
        {
            return MasterID + " - " + FromDateTime + " - " + ToDateTime + " - " + Value;
        }
    }
}
