using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Newtonsoft.Json;
using Serilog;

namespace WebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"

        };

        private readonly ILogger _logger;

        public WeatherForecastController(ILogger logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public WeatherForecast Get()
        {

            WeatherForecast wf = new WeatherForecast();
            var ng = new Random();
            string weather = "{\"Date\":\"2020-10-11T03:24:09.4308469+00:00\",\"TemperatureC\":31,\"TemperatureF\":0,\"Summary\":\"Mild\"}";
            //wf.Date = DateTime.Now.AddDays(0);
            //wf.TemperatureC = ng.Next(-20, 55);
            //wf.TemperatureF = 32;
            //wf.Summary = Summaries[ng.Next(Summaries.Length)];
            


            //string output = JsonConvert.SerializeObject(wf);
            WeatherForecast deserializedWeatherForecast = JsonConvert.DeserializeObject<WeatherForecast>(weather);
            //deserializedWeatherForecast.TemperatureC = 45;

            //_logger.Information("hello {summaries}", Summaries);
            //var output1 = JsonConvert.DeserializeObject(output);
            _logger.Information(string.Format("Date: {0}, TemperatureC: {1}, TemperatureF: {2}, Summary: {3}", deserializedWeatherForecast.Date.ToString(), deserializedWeatherForecast.TemperatureC.ToString(), deserializedWeatherForecast.TemperatureF.ToString(), deserializedWeatherForecast.Summary.ToString()));
           
            
            return deserializedWeatherForecast;
          
            

        }

        
    }

}



        

       
    

