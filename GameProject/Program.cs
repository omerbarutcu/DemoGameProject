using GameProject.Concrete;
using GameProject.Entities;

namespace GameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.Id = 1;
            gamer1.FirstName = "Omer";
            gamer1.LastName = "Barutcu";
            gamer1.DateOfBirth = 1985;
            gamer1.NationalId = 12345;

            Campaign campaign1 = new Campaign();
            campaign1.Id = 1;
            campaign1.Name = "Yılbaşı Kampanyası";
            campaign1.DiscountRate = 17;

            Game game1 = new Game();
            game1.Id = 1;
            game1.GameName = "Super Mario";
            game1.UnitPrice = 65;
            game1.Campaign = campaign1;


            GamerManager gamerManager = new GamerManager(new GamerCheckManager());
            gamerManager.Add(gamer1);

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);

            GameOrderManager gameOrderManager = new GameOrderManager();
            gameOrderManager.SellGame(gamer1, game1);
            
        }
    }
}
