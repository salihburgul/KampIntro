using GameProject.Concrete;
using GameProject.Entities;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.FirstName = "Salih";
            gamer1.LastName = "Burgul";
            gamer1.Id = 01;
            gamer1.NationalityId = "123456789";
            gamer1.BirthOfDate  = 1998;

            GamerManager gamerManager = new(new CheckManager());

            gamerManager.Add(gamer1);
            
            Game game1 = new Game();
            game1.GameId = 01;
            game1.GameName = "Star Wars: Jedi Academy ";
            game1.GamePrice = 10;

            GameManager gameManager = new GameManager();

            gameManager.Add(game1);


            Campaign campaign1 = new Campaign();
            campaign1.CampaignId = 03;
            campaign1.CampaignName = "Son Bahar İndirimi";
            campaign1.CampaignDiscount = 25;

            CampaignManager campaignManager = new CampaignManager();

            campaignManager.Add(campaign1);


        }
    }
   
}