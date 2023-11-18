using OpenWeatherMap.Standard;
using OpenWeatherMap.Standard.Enums;
using OpenWeatherMap.Standard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PD01_Parker_Johnson.WebPages
{
    public partial class Index : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
           
            
        }
        protected async void weather(string city)
        {
            try
            {
                Current currentWeather = new Current("586eb32c176b4a4331afaffa224b3c14", WeatherUnits.Metric);

                WeatherData data = await currentWeather.GetWeatherDataByCityName(city);

                string date = data.AcquisitionDateTime.ToString("dd/mm/yyyy");


                lblCity.Text = city + " On: " + date;
                lblTemp.Text = $"{data.WeatherDayInfo.Temperature} °C";

                ForecastData forecastData = await currentWeather.GetForecastDataByCityNameAsync(city);

                lblForecast.Text = data.Precipitation.ToString();

                lblFail.Text = ""; // Clear the failure message if successful
            }
            catch (Exception ex)
            {
                lblFail.Text = "Unfortunately, the city does not exist or the data is not available.";
                lblCity.Text = "";
                lblTemp.Text = "";
                lblForecast.Text = "";
            }
        }

        protected void btnCity_Click(object sender, EventArgs e)
        {
            string city = txtCity.Text;
            weather(city);
            return;
        }
    }
}