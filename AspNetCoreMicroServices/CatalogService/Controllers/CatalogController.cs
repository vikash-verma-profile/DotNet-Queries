using CatalogService.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogService.Controllers
{
    [Route("api/catalog")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        ICatalogService _catalogService;
        public CatalogController(ICatalogService catalogService)
        {
            _catalogService = catalogService;
        }
        [HttpGet("findall")]
        public IActionResult FindAll()
        {
            try
            {
                return Ok(_catalogService.FindAll());
            }
            catch 
            {
                return BadRequest();
            }
           
        }
        [HttpGet("findone")]
        public string Findone()
        {
            return "Hi";

        }
    }
}
