using System;
using System.Collections.Generic;
using System.Text;
using WeatherPrediction.Model.ViewModel;

namespace WeatherPrediction.Service.Interface
{
    public interface IPredictionInformationService
    {BaseResponseViewModel CreateForecast(WeatherinformationRequestModel model);

     WeatherInformationResponseViewModel GetWeatherForecaste(DateTime date);

     BaseResponseViewModel DeleteWeather(Guid id);


     BaseResponseViewModel UpdateWeather(Guid id, WeatherinformationRequestModel model);


    }
}


///nEW aSSIGNMENT
///

//Create a forecast app
//Let user be able to create/update forecast
//Let user be able to fetch forecast by mail
//let user be able to fetch forcast by date
//let user be able to delete
