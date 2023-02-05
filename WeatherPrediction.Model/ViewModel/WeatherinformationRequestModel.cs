using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherPrediction.Model.ViewModel
{
    public class WeatherinformationRequestModel
    {
        public double Wetbulb { get; set; }
        public double DryBulb { get; set; }
        public double Dewpoint { get; set; }

        public string Email { get; set; }
        public int Visibility { get; set; }
        public DateTime ForecastDate { get; set; }
        public double MinimumTemperature { get; set; }
    }
}
