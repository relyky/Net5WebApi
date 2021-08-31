using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NetCoreWebApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NetCoreWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PushLogController : ControllerBase
    {
        readonly ILogger<PushLogController> _logger;

        public PushLogController(ILogger<PushLogController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public void Post(dynamic jsonObject)
        {
            string json = JsonSerializer.Serialize(jsonObject, new JsonSerializerOptions
            {
                WriteIndented = false,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            });

            _logger.LogInformation(json);
        }

        //[HttpPost]
        //public void Post(PushEvent jsonObject)
        //{
        //    string json = JsonSerializer.Serialize(jsonObject, new JsonSerializerOptions
        //    {
        //        WriteIndented = false,
        //        Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        //    });
        //    _logger.LogInformation(json);
        //}
    }
}
