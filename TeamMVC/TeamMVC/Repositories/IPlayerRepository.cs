using System.Collections.Generic;
using TeamMVC.Models;

namespace TeamMVC.Repositories
{
    public interface IPlayerRepository
    {
        IList<PlayerViewModel> GetPlayers();
        void CreatePlayer(CreatePlayerViewModel player);
    }
}