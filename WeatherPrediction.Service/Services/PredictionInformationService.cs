using System;
using System.Collections.Generic;
using System.Text;
using WeatherPrediction.Migrations;
using WeatherPrediction.Model.Entity;
using WeatherPrediction.Model.ViewModel;
using WeatherPrediction.Service.Interface;

namespace WeatherPrediction.Service.Services
{
    public class PredictionInformationService : IPredictionInformationService
    {
        private readonly WeatherInformationDataBaseContext _context;
        public PredictionInformationService(WeatherInformationDataBaseContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Everybody can have just a unique firecase fo a day
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public BaseResponseViewModel CreateForecast(WeatherinformationRequestModel model)
        {
            var prediction = _context.WeatherInfos.FirstOrDefault(x => x.ForecastDate == model.ForecastDate);
            if (prediction == null)
            {
                var info = new WeatherInfo(); //construct new record
                info.Id = Guid.NewGuid();
                info.MinimumTemperature = model.MinimumTemperature;
                info.DryBulb = model.DryBulb;
                info.Dewpoint = model.Dewpoint;
                info.Email = model.Email;
                info.CreatedDate = DateTime.Now;
                _context.WeatherInfos.Add(info);
                _context.SaveChanges();
                return new BaseResponseViewModel
                {
                    Message = "Created Successfully",
                    Status = true
                };


            }
            else
            {
                //if prediction is not null... update the prediction record
                prediction.MinimumTemperature = model.MinimumTemperature;
                prediction.DryBulb = model.DryBulb;
                prediction.Dewpoint = model.Dewpoint;
                prediction.Email = model.Email;
                prediction.UpdatedDate = DateTime.Now;
                _context.WeatherInfos.Update(prediction);
                _context.SaveChanges();

                return new BaseResponseViewModel
                {
                    Message = "Forecast Updated Successfully",
                    Status = false
                };
            }
        }

        public WeatherInformationResponseViewModel GetWeatherForecaste(DateTime date)
        {

            var Weather = _context.WeatherInfos.FirstOrDefault(x => x.ForecastDate.Year == date.Year && x.ForecastDate.Month == date.Month && x.ForecastDate.Day == date.Day);
            if (Weather != null)
            {
                return new WeatherInformationResponseViewModel
                {
                    Email = Weather.Email,
                    Wetbulb = Weather.Wetbulb,
                    DryBulb = Weather.DryBulb,
                    Dewpoint = Weather.Dewpoint,
                    Visibility = Weather.Visibility,
                    CreatedDate = Weather.CreatedDate
                };
                //year, month, day, hour, minute, sec, msec, nan.sec
            }
            else
            {
                return null;
            }
        } 
        public BaseResponseViewModel DeleteWeather(Guid id)
        {
            var Weather = _context.WeatherInfos.FirstOrDefault(x => x.Id == id);
            if (Weather != null)
            {
                _context.WeatherInfos.Remove(Weather);
                _context.SaveChanges();

                return new BaseResponseViewModel
                {
                    Message = "Successful",
                    Status = true
                };
            }

            else
            {
                return new BaseResponseViewModel
                {
                    Message = "Parameter does not exist",
                    Status = false
                };
            }



        }

        public BaseResponseViewModel UpdateWeather(Guid id, WeatherinformationRequestModel model)
        {
            var Weather = _context.WeatherInfos.FirstOrDefault(x => x.Id == id);

            if (Weather != null)
            {
                Weather.Wetbulb = Weather.Wetbulb;
                Weather.DryBulb = Weather.DryBulb;
                Weather.Dewpoint = Weather.Dewpoint;
                Weather.Visibility = Weather.Visibility;
                Weather.Email= Weather.Email;
                Weather.MinimumTemperature = Weather.MinimumTemperature;

                _context.WeatherInfos.Update(Weather);
                _context.SaveChanges();

                return new BaseResponseViewModel
                {
                    Message = "Successful",
                    Status = true
                };

            }

            else
            {
                return new BaseResponseViewModel
                {
                    Message = "Parameter does not exist",
                    Status = false
                };
            }
        }
    } 
} 