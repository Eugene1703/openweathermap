using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    internal class ParseLatLonResponse
    {
        public LocationDataInfo LocationData { get; set; }  
        public class LocationDataInfo
        {
            public string Name { get; set; }
            public LocalNames LocalNames { get; set; }
            public double Lat { get; set; }
            public double Lon { get; set; }
            public string Country { get; set; }
            public string State { get; set; }
        }

        public class LocalNames
        {
            public string BG { get; set; }
            public string RU { get; set; }
            public string RO { get; set; }         
        }
        public LocationDataInfo Parse(string jsonResponse)
        {
            try
            {
                var cityDataList = JsonConvert.DeserializeObject<List<LocationDataInfo>>(jsonResponse);
                if (cityDataList != null && cityDataList.Count > 0)
                {
                    var cityData = cityDataList[0];
                    return cityData;
                }
                else
                {
                    throw new Exception("Have no data about city");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
