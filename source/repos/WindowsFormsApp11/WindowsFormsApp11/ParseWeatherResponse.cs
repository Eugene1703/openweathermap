using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WindowsFormsApp11
{
    internal class ParseWeatherResponse
    {
        public MainInfo Main { get; set; }
        public SysInfo Sys { get; set; }
        public string Name { get; set; }
        public WindInfo Wind {get; set;}
       
        public class MainInfo
        {
            public double Temp { get; set; }
            public double Feels_like { get; set; }
            public int Pressure { get; set; }
            public int Humidity { get; set; }
          
        }
        public class SysInfo
        {
            public string Country { get; set; }
        }
        public class WindInfo
        {
            public double Speed { get; set; }
        }

        public ParseWeatherResponse Parse(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<ParseWeatherResponse>(json);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
