using System;
using System.Globalization;
using CsvHelper;

namespace Uge43
{
    public class DataHandler
    {
        public string DataFileName { get; }
        private MeasurementRepository measurementRepository = new MeasurementRepository();

        public DataHandler(string dataFileName)
        {
            this.DataFileName = dataFileName;
        }

        public void LoadMeasurements()
        {
            using (var reader = new StreamReader("Måledata-2-år.csv"))
            {
                string header = reader.ReadLine();
                string date = "yyyy-MM-dd HH,mm";
                string fromDateString, toDateString;

                while (!reader.EndOfStream && reader.ReadLine() != header)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(';');
                    fromDateString = values[1];
                    toDateString = values[2];
                   
                    double masterID = double.Parse(values[0]);
                    DateTime fromDateTime = DateTime.ParseExact(fromDateString, date, CultureInfo.CurrentCulture);
                    DateTime toDateTime = DateTime.ParseExact(toDateString, date, CultureInfo.CurrentCulture);
                    double value = Double.Parse(values[3]);

                    measurementRepository.Create(new Measurement(masterID, fromDateTime, toDateTime, value));
                }
                measurementRepository.ReadAll();                
            }
        }
        /*
         *  itemList.Add(new Måledata()
                {
                    MasterID = values[0],
                    FromDateTime = Convert.ToDateTime(values[1]),
                    ToDateTime = Convert.ToDateTime(values[2]),
                    Value = double.Parse(values[3])

                });
         */
    }
}