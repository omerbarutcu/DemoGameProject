using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
     internal class GamerManager : IGamerService
    {
        private IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public void Add(Gamer gamer)
        {
            if(_gamerCheckService.CheckIfRealGamer(gamer))
            {
                Console.WriteLine(gamer.FirstName + " : oyuncusu eklendi.");
            }
            else
            {
                Console.WriteLine(gamer.FirstName + " : oyuncusu eklenemedi." + " E-devlet sisteminden doğrulanamadı.");
            }
        }

        public void Remove(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " : oyuncusu silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " : oyuncusu güncellendi.");
        }
    }
}
