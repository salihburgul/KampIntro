using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    internal class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign )
        {
            Console.WriteLine(campaign.CampaignName +" "+ "Yeni Kampanya" +" "+ "%" + campaign.CampaignDiscount + " "+ "İndirimi Kaçırmayın!");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "Kampanyanın süresi doldu");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "Kampanya güncellendi");
            Console.WriteLine("Mevcut fiyat İndirimi " + campaign.CampaignDiscount);
        }
    }
}
