using System;
using System.Xml.Linq;

namespace Uge43
{
    public class MeasurementRepository : IRepository
    {
        public List<Measurement> Measurements = new List<Measurement>();

        public void ReadAll()
        {
            foreach(Measurement measurement in Measurements)
            {
                Console.WriteLine(measurement);
            }
            //Console.WriteLine(Measurements.Count);
        }

        public Measurement GetByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public void Create(Measurement measurement)
        {
            Measurements.Add(measurement);
        }

        public void Update(Measurement measurement)
        {
            throw new NotImplementedException();
        }

        public void Delete(Measurement measurement)
        {
            throw new NotImplementedException();
        }
    }
}