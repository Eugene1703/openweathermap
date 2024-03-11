using System;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        static string apiKey = "91b7dc66f976e477e272de3e00fffd5d";
        double lat;
        double lon;
        string apiWeatherUrl;
        bool isLatLonIni = false;
        public Form1()
        {
            InitializeComponent();
            cityNameTextBox.KeyPress += cityNameTextBox_KeyPress;
        }
        private void ChangeFontLabel()
        {
            Font commonFont = new Font("Times New Roman", 16, FontStyle.Bold);
            foreach (Label label in Controls.OfType<Label>())
            {
                label.Font = commonFont;
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 60000;
            timer2.Interval = 10000;
            timer1.Enabled = false;
            timer2.Enabled = false;
            ChangeFontLabel();
            cityNameTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
            cityNameTextBox.Location = new Point(enterCityNameLabel.Right + 5, enterCityNameLabel.Top+4);

        }
        static double KelvinToCelsius(double kelvin)
        {
            return kelvin - 273.15;
        }
        async Task GetLatLon(string cityName)
        {
            string apiLatLonUrl = $"https://api.openweathermap.org/geo/1.0/direct?q={cityName}&limit=1&appid={apiKey}";
            try
            {
                string apiResponse = await MakeApiRequest(apiLatLonUrl);
                if (apiResponse != null)
                {
                    ParseLatLonResponse Parser = new ParseLatLonResponse();
                    var cityData = Parser.Parse(apiResponse);
                    if (cityData != null)
                    {
                        lat = cityData.Lat;
                        lon = cityData.Lon;
                        isLatLonIni = true;
                    }
                }
                else
                {
                    throw new Exception("API Response is null");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        async Task ShowInfo(string apiUrl)
        {
            try
            {
                string apiResponse = await MakeApiRequest(apiUrl);

                if(apiResponse != null)
                {
                    ParseWeatherResponse Parser = new ParseWeatherResponse();
                    ParseWeatherResponse Result = Parser.Parse(apiResponse);
                    temperatureLabel.Text = "Temperature: " + Convert.ToString(Math.Round(KelvinToCelsius(Result.Main.Temp),2)) + " °C";
                    feelsLikeTemperatureLabel.Text = "Feels like: " + Convert.ToString(Math.Round(KelvinToCelsius(Result.Main.Feels_like), 2)) + " °C";
                    cityLabel.Text = "City/region of data collection: " + Result.Name;
                    countryLabel.Text = "Country: " + Result.Sys.Country;
                    windSpeedLabel.Text = "Wind speed: " + Result.Wind.Speed + " m/s";
                }
                else
                {
                    throw new Exception("API response is null");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        async Task<string> MakeApiRequest(string apiUrl)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response != null && response.IsSuccessStatusCode)
                    {
                        string responseData = await response.Content.ReadAsStringAsync();
                        return responseData;
                    }
                    else
                    {
                        throw new Exception("API request return null");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            await ShowInfo(apiWeatherUrl);
        }
        private async void enterCityNameLabel_Click(object sender, EventArgs e)
        {          }

        private void cityNameTextBox_TextChanged(object sender, EventArgs e)
        {        }
        private async void cityNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                try
                {
                    isLatLonIni = false;
                    string enterData = cityNameTextBox.Text;
                    if (!string.IsNullOrEmpty(enterData))
                    {
                        await GetLatLon(enterData);
                        if(isLatLonIni)
                        {
                            apiWeatherUrl = $"https://api.openweathermap.org/data/2.5/weather?lat={lat}&lon={lon}&appid={apiKey}";
                            await ShowInfo(apiWeatherUrl);
                            timer1.Enabled = true;
                        }
                        else
                        {
                            timer1.Enabled = false;
                            throw new Exception("Check data");
                        }
                    }
                    else
                    {
                        throw new Exception("Check data");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private async void timer2_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
