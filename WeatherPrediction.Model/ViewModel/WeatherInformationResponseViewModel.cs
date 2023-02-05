using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherPrediction.Model.ViewModel
{
    public class WeatherInformationResponseViewModel
    {
        public double Wetbulb { get; set; }
        public double DryBulb { get; set; }
        public double Dewpoint { get; set; }
        public int Visibility { get; set; }
        public string Email { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
