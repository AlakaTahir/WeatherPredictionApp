using System;
using System.Collections.Generic;
using System.Text;
using WeatherPrediction.Model.Enum;

namespace WeatherPrediction.Model.Entity
{
   
    public class WeatherInfo
    {
        public Guid Id { get; set; }
        public double MinimumTemperature { get; set; }
        public double MaximumTemperature { get; set; }
        public double RelativeHumidity { get; set; }
        public double Wind { get; set; }
        public int Visiblity { get; set; }
        public Cloud Cloud { get; set; }
        public double Dewpoint { get; set; }
        public double Pressure { get; set; }
        public char DefaultTemperatureSymbol { get; set; } 
        public double WetBulb { get; set; }
        public double DryBulb { get; set; }
        public string Email { get; set; }
        public DateTime ForecastDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

    }
}
