using System;
using System.Globalization;
using CsvHelper;

namespace Uge43
{
    public class DataHandler
    {
        public string DataFileName { get; }
         

        public DataHandler(string dataFileName)
        {
            this.DataFileName = dataFileName;
        }

        public void LoadMåledata()
        {
            using (var reader = new StreamReader("Måledata-2-år.csv"))
            {
                List<Måledata> itemList = new List<Måledata>();
                Måledata måledata = new Måledata();
                string header = reader.ReadLine();
                string date = "yyyy-MM-dd HH,mm";
                string fromDateString, toDateString; 
                while (!reader.EndOfStream && reader.ReadLine() != header)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(';');
                    fromDateString = values[1];
                    toDateString = values[2];
                   
                    måledata.MasterID = double.Parse(values[0]);
                    måledata.FromDateTime = DateTime.ParseExact(fromDateString, date, CultureInfo.CurrentCulture);
                    måledata.ToDateTime = DateTime.ParseExact(toDateString, date, CultureInfo.CurrentCulture);
                    måledata.Value = Double.Parse(values[3]);
                    
                    itemList.Add(måledata);

                    foreach (var item in itemList)
                    {
                        Console.WriteLine(item);
                    }

                }
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

