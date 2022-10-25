using System;
using System.Globalization;

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
            
            using (var reader = new StreamReader("Måledata2år"))
            {
                List<Måledata> itemList = new List<Måledata>();
                Måledata måledata = new Måledata();

                string date = "yyyy-MM-dd hh,mm";
                DateTime dateTime;
                string fromDateString, toDateString; 
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');
                    fromDateString = values[1];
                    toDateString = values[2];
                   
                    måledata.MasterID = int.Parse(values[0]);
                    måledata.FromDateTime = DateTime.ParseExact(fromDateString, date, CultureInfo.CurrentCulture);
                    måledata.ToDateTime = DateTime.ParseExact(toDateString, date, CultureInfo.CurrentCulture);
                    måledata.Value = Double.Parse(values[3]);
                    
                    itemList.Add(måledata);

                    Console.WriteLine(int.Parse(values[0]));

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

