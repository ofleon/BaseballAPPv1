using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BaseballAPP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private List<string> Players = [];

        [HttpGet("GetNamePlayer")]
        public string GetNameofPlayer()
        {
            return "Alex";
        }

        [HttpGet("GetListPlayers")]
        public List<string> GetPlayerGetNameofPlayersofPlayer()
        {
            return Players;
        }


        [HttpPost]
        public bool CreateNewPlayer(string Name)
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                return false;
            }

            Players.Add(Name);
            return true;
        }
    }
}
