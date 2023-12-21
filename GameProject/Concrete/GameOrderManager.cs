using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    internal class GameOrderManager : IGameOrderService
    {
        public void SellGame(Gamer gamer, Game game)
        {
            if(game.Campaign!=null)
            {
                double GamePrice = (game.UnitPrice*game.Campaign.DiscountRate)/ 100;
                game.UnitPrice = game.UnitPrice-GamePrice;
                Console.WriteLine(gamer.FirstName + " isimli oyuncu " + game.GameName + " oyununu " + game.UnitPrice + " tl'ye satın aldı.");
            }
            else
            {
                Console.WriteLine(gamer.FirstName + " isimli oyuncu " + game.GameName + " oyununu " + game.UnitPrice + " tl'ye satın aldı.");
            }
        }
    }
}
