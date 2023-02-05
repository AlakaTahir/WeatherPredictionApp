using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using WeatherPrediction.Model.ViewModel;
using WeatherPrediction.Service.Interface;

namespace WeatherPrediction.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PredictionInformationController : ControllerBase
    {
        private readonly IPredictionInformationService _predictionInformationService;
        public PredictionInformationController(IPredictionInformationService predictionInformationService)
        {
            _predictionInformationService = predictionInformationService;
        }
        [HttpPost]
        public IActionResult CreatePrediction(WeatherinformationRequestModel model)
        {
            var response = _predictionInformationService.CreateForecast(model);
            return Ok(response);
        }

        [HttpGet]
        public IActionResult GetWeather(DateTime date)
        {
            var response = _predictionInformationService.GetWeatherForecaste(date);
            return Ok(response);

        }
        [HttpPut]
        public IActionResult UpdateWeather(Guid id, WeatherinformationRequestModel model)
        {
            var response = _predictionInformationService.UpdateWeather(id, model);
            return Ok(response);
       }
        [HttpDelete]
        public IActionResult DeleteWeather(Guid id)
        {
            var response = _predictionInformationService.DeleteWeather(id);
            return Ok(response);
        }

    }
}
