using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TeamMVC.Data;
using TeamMVC.Data.Models;
using TeamMVC.Models;

namespace TeamMVC.Repositories
{
    public class PlayerDataRepository : IPlayerRepository
    {
        private TeamDbContext _db = new TeamDbContext();

        //CRUD Operations

        public IList<PlayerViewModel> GetPlayers()
        {
                return _db.Players.Select(p => new PlayerViewModel
                {
                    PlayerName = p.FirstName + " " + p.LastName,
                    TeamCity = p.Team.City,
                    TeamName = p.Team.Name
                }).ToList();
        }

        public void CreatePlayer(CreatePlayerViewModel player)
        {
            Player dbPlayer = new Player
            {
                FirstName = player.FirstName,
                LastName = player.LastName,
                TeamId = player.SelectedTeamId.Value
            };

            _db.Players.Add(dbPlayer);
            _db.SaveChanges();
        }
    }
}