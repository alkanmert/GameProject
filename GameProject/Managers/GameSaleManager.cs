using OOPProject.Objects;
using OOPProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject.Managers
{
    internal class GameSaleManager : IGameSaleService
    {
        public void Sale(Game game, User user,Campaign campaign)
        {
            float GameAmount = (game.GamePrice) - ((game.GamePrice * campaign.CampaignDiscountRate) / 100);
            Console.WriteLine(game.GameName + ", " + campaign.CampaignName + " Kampanyası dahilinde" + " %" +
                campaign.CampaignDiscountRate + " indirim oranı ile" + " " + GameAmount + " liraya satın alındı.");
        }
    }
}
