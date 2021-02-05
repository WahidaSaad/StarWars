using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeleQuebecStarWars.Models;


namespace TeleQuebecStarWars.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StarWarsController : ControllerBase
    {

        private IRepository repository;

        public StarWarsController(IRepository repo)
        {
            repository = repo;
        }

        [HttpGet]
        public IEnumerable<PersonnageModel> Get() => repository.Personnages;
    }
}
