using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sport;

namespace FootballPlayerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FootballPlayerController : ControllerBase
    {
        private Managers.FootballPlayerManager manager = new Managers.FootballPlayerManager();

        [HttpGet]
        public List<FootballPlayer> Get()
        {
            return manager.Get();
        }

        [HttpGet]
        [Route("{id}")]
        public FootballPlayer Get(int id)
        {
            return manager.Get(id);
        }

        [HttpGet]
        [Route("Name/{name}")]
        public List<FootballPlayer> Get(string name)
        {
            return manager.GetName(name);
        }

        [HttpPost]
        public bool Post([FromBody] FootballPlayer player)
        {
            return manager.Create(player);
        }

        [HttpPut]
        [Route("{id}")]
        public bool Put(int id, [FromBody] FootballPlayer player)
        {
            return manager.Update(id, player);
        }

        [HttpDelete]
        [Route("{id}")]
        public FootballPlayer Delete(int id)
        {
            return manager.Delete(id);
        }
    }
}
