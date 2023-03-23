using OOPProject.Managers;
using OOPProject.Objects;

internal class Program
{
    private static void Main(string[] args)
    {
        User user1 = new User();
        user1.Id = 1;
        user1.FirstName = "Mert";
        user1.LastName = "Alkan";
        user1.BirthYear = 1999;
        user1.IdentityNumber = 12356;

        UserManager userManager = new UserManager(new ValidationManager());
        userManager.Add(user1);
    
        Game game1 = new Game();
        game1.Id = 1;
        game1.GameName = "Age Of Mythology";
        game1.GamePrice = 100;

        GameManager gameManager = new GameManager();
        gameManager.Add(game1);

        Campaign campaign1 = new Campaign();
        campaign1.Id = 1;
        campaign1.CampaignName = "Hoşgeldin";
        campaign1.CampaignDiscountRate = 50;

        CampaignManager campaignManager = new CampaignManager();
        campaignManager.Add(campaign1);

        GameSaleManager gameSaleManager = new GameSaleManager();
        gameSaleManager.Sale(game1, user1, campaign1);
    }
}