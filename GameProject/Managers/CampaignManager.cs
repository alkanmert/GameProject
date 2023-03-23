using OOPProject.Objects;
using OOPProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject.Managers
{
    internal class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " " +  "kampanyası eklendi.") ;
        }

        public void Remove(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " " + "kampanyası silindi.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " " + "kampanyası güncellendi.");
        }
    }
}
